using Cinemate.Api.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore;

namespace Cinemate.Api.Brokers.Storages
{
	public partial class StorageBroker
	{
        public DbSet<VideoMetadata> VideoMetadatas { get; set; }
    }
}
