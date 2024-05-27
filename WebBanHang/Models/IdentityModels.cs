using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WebBanHang.Models.EF;

namespace WebBanHang.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Phone {  get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<ReviewProduct > Review { get; set; }
        public DbSet<Wishlist > Wishlists { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Adv> Advs { get; set; }
        public DbSet<ChiTietDH> ChiTietDHes { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<HinhanhSP> HinhanhSPes { get; set; }
        public DbSet<LienHe> LienHes  { get; set; }
        public DbSet<LoaiSp> LoaiSpes { get; set; }
        public DbSet<SanPham> SanPhames { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<QuangCao> QuangCaos { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<Arcticle> Arcticles { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }


        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }
    }
}