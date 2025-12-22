using DbWrapper.Core.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp99
{
    [Table("companies", "Компания")]
    public class Company : Entity
    {
        [Column("id")]
        [PrimaryKey]
        [CascadeDelete("trips", "company_id")]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

    }

    [Table("trips", "Рейс")]
    public class Trip : Entity
    {
        [Column("id")]
        [PrimaryKey]
        [CascadeDelete("tickets", "trip_id")]
        public int Id { get; set; }

        [Column("company_id")]
        [ForeignKey("companies")]
        [ComboField("Компания", "name")]
        public int CompanyId { get; set; }

        [FetchFrom("companies", "name", nameof(CompanyId))]
        public string? CompanyName { get; set; }

        [Column("town_from")]
        public string? TownFrom { get; set; }

        [Column("town_to")]
        public string? TownTo { get; set; }

        [Column("time_out")]
        public DateTime TimeOut { get; set; }

        [Column("time_in")]
        public DateTime TimeIn { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        public string? PassangerCount { get; set; }
    }

    [Table("tickets", "Билет")]
    public class Ticket : Entity
    {
        [Column("id")]
        [PrimaryKey]
        public int Id { get; set; }

        [Column("trip_id")]
        [ForeignKey("trips")]
        public int TripId { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("middle_name")]
        public string? MiddleName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

    }
}
