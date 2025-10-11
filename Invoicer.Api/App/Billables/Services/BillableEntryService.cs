using Invoicer.Api.App.Billables.Dtos;
using Invoicer.Api.App.Billables.Entities;
using Invoicer.Api.Common.EntityServices;
using Invoicer.Api.Services;

namespace Invoicer.Api.App.Billables.Services;

public class BillableEntryService : BaseEntityService<BillableEntry, Guid>
{
    public BillableEntryService( InvoicerContext dbContext ) : base( dbContext ) { }

    public async Task<BillableEntry> Create(BillableEntryDto model)
    {
        var entity = model.ToEntity();

        await db.AddAsync( entity );
        await db.SaveChangesAsync();

        return entity;
    }

    public async Task<BillableEntry> Update( BillableEntry entry, BillableEntryDto model )
    {
        entry.ApplyUpdate( model );
        
        db.Update( entry );
        await db.SaveChangesAsync();
    
        return entry;
    }

}
