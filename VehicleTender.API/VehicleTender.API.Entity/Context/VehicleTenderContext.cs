using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleTender.API.Entity.Entities;

namespace VehicleTender.API.Entity.Context
{
    public class VehicleTenderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //startupda adddbcontext kullanıyorsak bunu yazmak zorundayız aynen bu şekil
        {
            optionsBuilder.UseSqlServer("data source=.;database=VehicleTender;Integrated Security=true;");
        }

        #region Change Tracker

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                // To these sections,
                // Each time the SaveChanges() method is used, the actions to be taken before going to dB will be entered.
                switch (entry.State)
                {
                    case EntityState.Detached:
                        {
                            //If EntityState is Detached
                            break;
                        }
                       
                    case EntityState.Unchanged:
                        {
                            //If EntityState is unchanged
                            break;
                        }
                        
                    case EntityState.Deleted:
                        {
                            //If EntityState is Deleted
                            break;
                        }
                        
                    case EntityState.Modified:
                        {
                            //If EntityState is Modified
                            break;
                        }
                        
                    case EntityState.Added:
                        {
                            //If EntityState is Added
                            break;
                        }                       
                }
            }
            return base.SaveChanges();
        }

        #endregion

        public VehicleTenderContext()
        {

        } 
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<CarDetailInfo> CarDetailInfo { get; set; }
        public virtual DbSet<VehicleStatuHistory> VehicleStatuHistory { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<IndividualVehiclePurchase> IndividualVehiclePurchase { get; set; }
        public virtual DbSet<IndividualVehicleSales> IndividualVehicleSales { get; set; }
        public virtual DbSet<Expertise> Expertise { get; set; }
        public virtual DbSet<EnumCompanyType> EnumCompanyType { get; set; }
        public virtual DbSet<EnumPacket> EnumPacket { get; set; }
        public virtual DbSet<EnumStatuType> EnumStatuType { get; set; }
        public virtual DbSet<Favorite> Favorite { get; set; }
        public virtual DbSet<BuyingTenderVehicle> BuyingTenderVehicle { get; set; }
        public virtual DbSet<TenderVehicleSales> TenderVehicleSales { get; set; }
        public virtual DbSet<AdvertInfo> AdvertInfo { get; set; }
        public virtual DbSet<Commission> Commission { get; set; }
        public virtual DbSet<CorporateDetail> CorporateDetail { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Notary> Notary { get; set; }
        public virtual DbSet<PacketAuthority> PacketAuthority { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAuthority> RoleAuthority { get; set; }
        public virtual DbSet<RoleUser> RoleUser { get; set; }
        public virtual DbSet<PurchasedVehicle> PurchasedVehicle { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<FavoriteSearchCriteria> FavoriteSearchCriteria { get; set; }
        public virtual DbSet<FavoriteFeature> FavoriteFeature { get; set; }
        public virtual DbSet<Hardware> Hardware { get; set; }
        public virtual DbSet<CompanyPacketHistory> CompanyPacketHistory { get; set; }
        public virtual DbSet<EnumMessage> EnumMessage { get; set; }
        public virtual DbSet<IndividualVehicleSalesStatuHistory> IndividualVehicleSalesStatuHistory { get; set; }
        public virtual DbSet<TenderStatuHistory> TenderStatuHistory { get; set; }
        public virtual DbSet<TramerPart> TramerPart { get; set; }
        public virtual DbSet<TramerSituationValue> TramerSituationValue { get; set; }
        public virtual DbSet<TramerValue> TramerValue { get; set; }
        public virtual DbSet<CarFeature> CarFeature { get; set; }
        public virtual DbSet<CarFeatureCodeMeaning> CarFeatureCodeMeaning { get; set; }
        public virtual DbSet<CarFeatureValue> CarFeatureValue { get; set; }
        public virtual DbSet<HardwareType> HardwareType { get; set; }
        public virtual DbSet<TenderVehicleDetail> TenderVehicleDetail { get; set; }

    }
}
