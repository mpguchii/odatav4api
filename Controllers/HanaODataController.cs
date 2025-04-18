using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.OData.UriParser;
using ODataNetCore.Models;
using Sap.Data.Hana;
using System.Data.Common;
using System.Text;

public class HanaODataController<T> : ODataController where T : class
{
    protected readonly HanaConnection _conn;

    public HanaODataController(HanaConnection conn)
    {
        _conn = conn;
    }

    protected async Task<IQueryable<T>> ExecuteODataQueryAsync(
       string tableName,
       ODataQueryOptions<T> options,
       Func<HanaDataReader, List<string>, T> mapper)
    {
        var sqlBuilder = new StringBuilder();
        var selectedColumns = new List<string>();
        if (options.SelectExpand?.RawSelect != null)
        {
            selectedColumns = options.SelectExpand.RawSelect.Split(',').Select(c => c.Trim()).ToList();
            var quotedColumns = selectedColumns.Select(c => $"\"{c}\"");
            sqlBuilder.Append($"SELECT {string.Join(", ", quotedColumns)} FROM \"{tableName}\"");
        }
        else
        {
            sqlBuilder.Append($"SELECT * FROM \"{tableName}\"");
        }
        if (options.Filter != null)
        {
            sqlBuilder.Append($" WHERE {options.Filter.RawValue.Replace(" eq ", " = ")}");
        }
        if (options.OrderBy != null)
        {
            sqlBuilder.Append($" ORDER BY {options.OrderBy.RawValue}");
        }
        if (options.Top != null || options.Skip != null)
        {
            sqlBuilder.Append($" LIMIT {options.Top?.Value ?? 100} OFFSET {options.Skip?.Value ?? 0}");
        }

        await _conn.OpenAsync();
        try
        {
            using var cmd = new HanaCommand(sqlBuilder.ToString(), _conn);
            using var reader = await cmd.ExecuteReaderAsync();

            var results = new List<T>();
            while (await reader.ReadAsync())
            {
                results.Add(mapper((HanaDataReader)reader, selectedColumns));
            }

            return results.AsQueryable();
        }
        finally
        {
            await _conn.CloseAsync();
        }
    }

    protected string TranslateFilter(FilterQueryOption filter)
    {
        return filter.RawValue
            .Replace(" eq ", " = ")
            .Replace(" ne ", " <> ")
            .Replace(" gt ", " > ")
            .Replace(" ge ", " >= ")
            .Replace(" lt ", " < ")
            .Replace(" le ", " <= ")
            .Replace(" and ", " AND ")
            .Replace(" or ", " OR ")
            .Replace("(", "\"")
            .Replace(")", "\"");
    }

    protected string TranslateOrderBy(OrderByQueryOption orderBy)
    {
        return orderBy.RawValue
            .Replace(" asc", " ASC")
            .Replace(" desc", " DESC")
            .Replace(",", ", ");
    }

    protected static string GetSafeString(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as string ?? string.Empty;
            }
            catch (IndexOutOfRangeException)
            {
                return string.Empty;
            }
        }
        return string.Empty;
    }

    protected static int GetSafeInt(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as int? ?? 0;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
        return 0;
    }

    protected static long GetSafeLong(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as long? ?? 0L;
            }
            catch (IndexOutOfRangeException)
            {
                return 0L;
            }
        }
        return 0L;
    }
    protected static decimal GetSafeDecimal(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as decimal? ?? 0;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
        return 0;
    }
    protected static double GetSafeDouble(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as double? ?? 0;
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
        }
        return 0;
    }

    protected static bool GetSafeBool(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as bool? ?? false;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }
        return false;
    }

    protected static DateTime GetSafeDateTime(HanaDataReader reader, string column, List<string> selectedColumns)
    {
        if (selectedColumns.Count == 0 || selectedColumns.Contains(column))
        {
            try
            {
                return reader[column] as DateTime? ?? DateTime.MinValue;
            }
            catch (IndexOutOfRangeException)
            {
                return DateTime.MinValue;
            }
        }
        return DateTime.MinValue;
    }

    protected void ProcessDynamicFields(CustomerOrders order, HanaDataReader reader,
                                     string prefix, int count, string[] suffixes, List<string> selectedColumns)
    {
        for (int i = 1; i <= count; i++)
        {
            foreach (var suffix in suffixes)
            {
                var propName = $"{prefix}_{i}_{suffix}";

                if(selectedColumns.Count == 0 || selectedColumns.Contains(propName))
                {
                    var prop = typeof(CustomerOrders).GetProperty(propName);
                    if (prop != null)
                    {
                        var value = reader[propName] is DBNull ? null : reader[propName];
                        prop.SetValue(order, value);
                    }
                }                
            }
        }
    }
}