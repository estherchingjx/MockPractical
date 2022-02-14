using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockPractical.Server.Configurations.Entities
{
    public class TaskSeedConfiguration : IEntityTypeConfiguration<Shared.Domain.Task>
    {
        public void Configure(EntityTypeBuilder<Shared.Domain.Task> builder)
        {
			builder.HasData(
			new Shared.Domain.Task
			{
				Id = 1,
				TaskName = "Eat frog",
				DueDate = DateTime.Today.AddDays(47),
				CreatedDate = DateTime.Today,
				CreatedBy = "Esther Ching"
			}
			);
		}
    }
}
