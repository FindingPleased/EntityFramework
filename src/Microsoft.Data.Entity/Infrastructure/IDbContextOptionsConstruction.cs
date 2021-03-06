// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata;

namespace Microsoft.Data.Entity.Infrastructure
{
    public interface IDbContextOptionsConstruction
    {
        IModel Model { [param: CanBeNull] set; }
        void AddOrUpdateExtension<TExtension>([NotNull] Action<TExtension> updater) where TExtension : EntityConfigurationExtension, new();
        void Lock();
    }
}
