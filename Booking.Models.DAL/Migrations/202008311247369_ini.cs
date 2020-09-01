namespace Booking.Models.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ini : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        HotelId = c.Int(nullable: false, identity: true),
                        HotelName = c.String(),
                        HotelLocation = c.String(),
                    })
                .PrimaryKey(t => t.HotelId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomID = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        RoomType = c.Int(nullable: false),
                        HotelID = c.Int(nullable: false),
                        RoomBookingID = c.Int(),
                    })
                .PrimaryKey(t => t.RoomID)
                .ForeignKey("dbo.Hotels", t => t.HotelID, cascadeDelete: true)
                .ForeignKey("dbo.RoomBookings", t => t.RoomBookingID)
                .Index(t => t.HotelID)
                .Index(t => t.RoomBookingID);
            
            CreateTable(
                "dbo.RoomBookings",
                c => new
                    {
                        RoomBookingID = c.Int(nullable: false, identity: true),
                        BookedDateFR = c.String(),
                        BookedDateTO = c.String(),
                        BookingStatus = c.String(),
                        PaymentStatus = c.String(),
                        AdvancePayed = c.String(),
                        TotalAmountPayed = c.String(),
                    })
                .PrimaryKey(t => t.RoomBookingID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "RoomBookingID", "dbo.RoomBookings");
            DropForeignKey("dbo.Rooms", "HotelID", "dbo.Hotels");
            DropIndex("dbo.Rooms", new[] { "RoomBookingID" });
            DropIndex("dbo.Rooms", new[] { "HotelID" });
            DropTable("dbo.RoomBookings");
            DropTable("dbo.Rooms");
            DropTable("dbo.Hotels");
        }
    }
}
