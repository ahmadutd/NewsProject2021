using AllNews.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data
{
    public class AllNewsDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AllNewsDbContext(DbContextOptions<AllNewsDbContext> Option)
            :base(Option)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            builder.Entity<AppUser>().HasMany(x => x.CreatedNews).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedNews).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedPapers).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedPapers).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedAudios).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedAudios).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedStatement).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedStatement).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedStudies).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedStudies).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedCompany).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedCompany).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedVideo).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedVideo).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);

            builder.Entity<AppUser>().HasMany(x => x.CreatedPhoto).WithOne(v => v.CreatedUser).HasForeignKey(v => v.CreatedBy);
            builder.Entity<AppUser>().HasMany(x => x.UpdatedPhoto).WithOne(v => v.UpdatedUser).HasForeignKey(v => v.UpdatedBy);



            builder.Entity<News>().HasOne(x => x.Category).WithMany(x => x.Newss).HasForeignKey(x => x.CategoryId);
            builder.Entity<Photo>().HasOne(x => x.Category).WithMany(x => x.Photos).HasForeignKey(x => x.CategoryId);
            builder.Entity<Video>().HasOne(x => x.Category).WithMany(x => x.Videos).HasForeignKey(x => x.CategoryId);
            builder.Entity<Paper>().HasOne(x => x.Category).WithMany(x => x.Paper).HasForeignKey(x => x.CategoryId);

            builder.Entity<NewsTag>().HasOne(x => x.News).WithMany(x => x.NewsTag).HasForeignKey(x => x.NewsId);
            builder.Entity<NewsTag>().HasOne(x => x.Tag).WithMany(x => x.NewsTag).HasForeignKey(x => x.TagId);

            builder.Entity<VideoTag>().HasOne(x => x.Videos).WithMany(x => x.VideoTag).HasForeignKey(x => x.VideoId);
            builder.Entity<VideoTag>().HasOne(x => x.Tag).WithMany(x => x.VideoTag).HasForeignKey(x => x.TagId);

            builder.Entity<PhotosTag>().HasOne(x => x.Photos).WithMany(x => x.PhotoTag).HasForeignKey(x => x.PhotoId);
            builder.Entity<PhotosTag>().HasOne(x => x.Tag).WithMany(x => x.PhotoTag).HasForeignKey(x => x.TagId);


            builder.Entity<Language>().HasMany(x => x.News).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Tags).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.MoveText).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Photo).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Video).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Audio).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Company).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Paper).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Statement).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Studies).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.Category).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);
            builder.Entity<Language>().HasMany(x => x.About).WithOne(x => x.SiteLanguage).HasForeignKey(x => x.LangId);

        }



        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }
        public virtual DbSet<Paper> Papers { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }
        public virtual DbSet<Company> Companys { get; set; }
        public virtual DbSet<MoveText> MoveTexts { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<NewsTag> NewsTags { get; set; }
        public virtual DbSet<VideoTag> VideoTags { get; set; }
        public virtual DbSet<PhotosTag> PhotoTags { get; set; }
        public virtual DbSet<SocialManagment> SocialManagments { get; set; }


    }
}
