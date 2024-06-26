﻿using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;

namespace Cinemate.Api.Brokers.Storages
{
	public partial class StorageBroker : EFxceptionsContext, IStorageBroker
	{
		private readonly IConfiguration configuration;

		public StorageBroker(IConfiguration configuration)
		{
			this.configuration = configuration;
			this.Database.Migrate();
		}


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = this.configuration.GetConnectionString(name: "DefaultConnection");

			optionsBuilder.UseSqlServer(connectionString);
		}
		public override void Dispose()
		{ }
	}
}
