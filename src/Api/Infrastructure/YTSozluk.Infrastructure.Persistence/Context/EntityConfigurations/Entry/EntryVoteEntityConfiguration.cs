﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTSozluk.Api.Domain.Models;

namespace YTSozluk.Infrastructure.Persistence.Context.EntityConfigurations.Entry;

public class EntryVoteEntityConfiguration : BaseEntityConfiguration<EntryVote>
{
    public override void Configure(EntityTypeBuilder<EntryVote> builder)
    {
        base.Configure(builder);

        builder.ToTable("entryvote", YTSozlukContext.DEFAULT_SCHEMA);

        builder.HasOne(i => i.Entry)
            .WithMany(i => i.EntryVotes)
            .HasForeignKey(i => i.EnrtyId);
    }
}
