﻿using Bssom.Serializer.Resolver;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(MapCodeGenResolver.ModuleName)]
[assembly: InternalsVisibleTo(IDictionaryResolver.ModuleName)]
[assembly: InternalsVisibleTo(ICollectionResolver.ModuleName)]
[assembly: InternalsVisibleTo("Bssom.Serializer.Test")]