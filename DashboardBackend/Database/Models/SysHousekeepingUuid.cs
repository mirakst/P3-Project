﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DashboardBackend.Database.Models
{
    [Table("SYS_HOUSEKEEPING_UUID")]
    [Index(nameof(SrcSchema), nameof(SrcTbl), nameof(ClnSchema), nameof(ClnTbl), nameof(Mgr), Name = "SYS_HOUSEKEEPING_UUID_UK", IsUnique = true)]
    public partial class SysHousekeepingUuid
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("SRC_SCHEMA")]
        [StringLength(400)]
        public string SrcSchema { get; set; }
        [Column("SRC_TBL")]
        [StringLength(400)]
        public string SrcTbl { get; set; }
        [Column("MGR")]
        [StringLength(400)]
        public string Mgr { get; set; }
        [Column("SRC_PRIMARYKEY")]
        [StringLength(400)]
        public string SrcPrimarykey { get; set; }
        [Column("ID_PREFIX")]
        [StringLength(400)]
        public string IdPrefix { get; set; }
        [Column("CLN_SCHEMA")]
        [StringLength(400)]
        public string ClnSchema { get; set; }
        [Column("CLN_TBL")]
        [StringLength(400)]
        public string ClnTbl { get; set; }
        [Column("CLN_PRIMARYKEY")]
        [StringLength(400)]
        public string ClnPrimarykey { get; set; }
    }
}
