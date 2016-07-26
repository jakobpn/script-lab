﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace OfficeJsSnippetsService.Service
{
    public interface ITableStorageService
    {
        Task<IList<T>> QueryAsync<T>(string tableName, string filter = null, int? take = default(int?)) where T : ITableEntity, new();
    }
}