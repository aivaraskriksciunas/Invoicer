using Riok.Mapperly.Abstractions;
using Invoicer.Api.App.Billables.Dtos;
using Invoicer.Api.App.Billables.Entities;

namespace Invoicer.Api.App.Billables.Services;

[Mapper]
public static partial class BillableMapper
{
    public static partial BillableEntry ToEntity( this BillableEntryDto dto );

    public static partial BillableEntryDto ToDto( this BillableEntry entity );

    public static partial void ApplyUpdate( [MappingTarget] this BillableEntry entity, BillableEntryDto dto );
}
