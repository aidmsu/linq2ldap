﻿using Linq2Ldap.Core.Models;
using Linq2Ldap.ExampleCommon.Specifications;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;

namespace Linq2Ldap.Protocols.Examples.Repository
{
    public interface ILdapRepository
    {
        T FindOne<T>(Specification<T> spec) where T: IEntry, new();

        T[] FindAll<T>(Specification<T> spec, int? limit = null) where T: IEntry, new();

        IEnumerable<T> Page<T>(
            Specification<T> spec,
            int offsetPage = 0, int pageSize = 10,
            SortKey[] sortKeys = null,
            bool withVlv = true
        )
            where T : IEntry, new();

        IEnumerable<T> PageWithPageControl<T>(
            Specification<T> spec,
            int offsetPage = 0, int pageSize = 10,
            SortKey[] sortKeys = null
        )
            where T : IEntry, new();

        IEnumerable<T> PageWithVLV<T>(
            Specification<T> spec,
            int offsetPage = 0, int pageSize = 10,
            SortKey[] sortKeys = null
        )
            where T : IEntry, new();

        void Add<T>(T entity) where T: IEntry, new();

        void Update<T>(T entity) where T: IEntry, new();
    }
}