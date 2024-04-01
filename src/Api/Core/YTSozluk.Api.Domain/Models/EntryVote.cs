using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTSozluk.Common.ViewModels;

namespace YTSozluk.Api.Domain.Models;

public class EntryVote :BaseEntity
{
    public Guid EnrtyId { get; set; }
    public VoteType voteType { get; set; }

    public Guid CreatedById { get; set; }

    public virtual Entry Entry { get; set; }
}
