using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EasyImmo.Data.Entities;

public partial class EasyImmoContext : DbContext
{
    public EasyImmoContext()
    {
    }

    public EasyImmoContext(DbContextOptions<EasyImmoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<AgentEvent> AgentEvents { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Folder> Folders { get; set; }

    public virtual DbSet<FolderEvent> FolderEvents { get; set; }

    public virtual DbSet<FolderStep> FolderSteps { get; set; }

    public virtual DbSet<Listing> Listings { get; set; }

    public virtual DbSet<ListingType> ListingTypes { get; set; }

    public virtual DbSet<Municipality> Municipalities { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Photo> Photos { get; set; }

    public virtual DbSet<PostalCode> PostalCodes { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<PropertyDetail> PropertyDetails { get; set; }

    public virtual DbSet<PropertyType> PropertyTypes { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<StepType> StepTypes { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ALEXANDRE\\SQLEXPRESS;Database=EasyImmo;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__Address__091C2A1B44A15BC8");

            entity.ToTable("Address");

            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.BoxNumber).HasMaxLength(20);
            entity.Property(e => e.StreetId).HasColumnName("StreetID");

            entity.HasOne(d => d.Street).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.StreetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Address__StreetI__5165187F");
        });

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("PK__Agent__9AC3BFD1DD40F914");

            entity.ToTable("Agent");

            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.EmailAgent).HasMaxLength(100);
            entity.Property(e => e.FirstNameAgent).HasMaxLength(50);
            entity.Property(e => e.LastNameAgent).HasMaxLength(50);
            entity.Property(e => e.PasswordAgent).HasMaxLength(255);
            entity.Property(e => e.PhoneAgent).HasMaxLength(20);
        });

        modelBuilder.Entity<AgentEvent>(entity =>
        {
            entity.HasKey(e => e.AgentEventId).HasName("PK__AgentEve__7979E27363C955FA");

            entity.ToTable("AgentEvent");

            entity.Property(e => e.AgentEventId).HasColumnName("AgentEventID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.EventId).HasColumnName("EventID");

            entity.HasOne(d => d.Agent).WithMany(p => p.AgentEvents)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AgentEven__Agent__76969D2E");

            entity.HasOne(d => d.Event).WithMany(p => p.AgentEvents)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AgentEven__Event__778AC167");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__10D160BF92F039B3");

            entity.ToTable("Country");

            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.CountryName).HasMaxLength(100);
            entity.Property(e => e.IsoCode).HasMaxLength(10);
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__Document__1ABEEF6F7E0E32B7");

            entity.ToTable("Document");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentPath).HasMaxLength(255);
            entity.Property(e => e.DocumentSignatureDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.Documents)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Document__Docume__72C60C4A");

            entity.HasOne(d => d.Folder).WithMany(p => p.Documents)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Document__Folder__73BA3083");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.HasKey(e => e.DocumentTypeId).HasName("PK__Document__DBA390C15BA69A3E");

            entity.ToTable("DocumentType");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.DocumentTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PK__Event__7944C8706E678D79");

            entity.ToTable("Event");

            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventNote).HasMaxLength(255);
            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");

            entity.HasOne(d => d.EventType).WithMany(p => p.Events)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Event__EventType__59063A47");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("PK__EventTyp__A9216B1F329B546F");

            entity.ToTable("EventType");

            entity.Property(e => e.EventTypeId).HasColumnName("EventTypeID");
            entity.Property(e => e.EventTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Folder>(entity =>
        {
            entity.HasKey(e => e.FolderId).HasName("PK__Folder__ACD7109F5B35A50C");

            entity.ToTable("Folder");

            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderCloseDate).HasColumnType("datetime");
            entity.Property(e => e.FolderCloseReason).HasMaxLength(255);
            entity.Property(e => e.FolderOpenDate).HasColumnType("datetime");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");

            entity.HasOne(d => d.Listing).WithMany(p => p.Folders)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Folder__ListingI__6B24EA82");

            entity.HasOne(d => d.Person).WithMany(p => p.Folders)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Folder__PersonID__6C190EBB");
        });

        modelBuilder.Entity<FolderEvent>(entity =>
        {
            entity.HasKey(e => e.FolderEventId).HasName("PK__FolderEv__531FA6D49937FBEC");

            entity.ToTable("FolderEvent");

            entity.Property(e => e.FolderEventId).HasColumnName("FolderEventID");
            entity.Property(e => e.EventId).HasColumnName("EventID");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");

            entity.HasOne(d => d.Event).WithMany(p => p.FolderEvents)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FolderEve__Event__7B5B524B");

            entity.HasOne(d => d.Folder).WithMany(p => p.FolderEvents)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FolderEve__Folde__7A672E12");
        });

        modelBuilder.Entity<FolderStep>(entity =>
        {
            entity.HasKey(e => e.FolderStepId).HasName("PK__FolderSt__D0CAACC4394BA4BB");

            entity.ToTable("FolderStep");

            entity.Property(e => e.FolderStepId).HasColumnName("FolderStepID");
            entity.Property(e => e.FolderId).HasColumnName("FolderID");
            entity.Property(e => e.FolderStepDate).HasColumnType("datetime");
            entity.Property(e => e.FolderStepNote).HasMaxLength(255);
            entity.Property(e => e.StepTypeId).HasColumnName("StepTypeID");

            entity.HasOne(d => d.Folder).WithMany(p => p.FolderSteps)
                .HasForeignKey(d => d.FolderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FolderSte__Folde__6EF57B66");

            entity.HasOne(d => d.StepType).WithMany(p => p.FolderSteps)
                .HasForeignKey(d => d.StepTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FolderSte__StepT__6FE99F9F");
        });

        modelBuilder.Entity<Listing>(entity =>
        {
            entity.HasKey(e => e.ListingId).HasName("PK__Listing__BF3EBEF071468BC1");

            entity.ToTable("Listing");

            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.AgentId).HasColumnName("AgentID");
            entity.Property(e => e.ListingEndDate).HasColumnType("datetime");
            entity.Property(e => e.ListingStartDate).HasColumnType("datetime");
            entity.Property(e => e.ListingTypeId).HasColumnName("ListingTypeID");
            entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

            entity.HasOne(d => d.Agent).WithMany(p => p.Listings)
                .HasForeignKey(d => d.AgentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Listing__AgentID__68487DD7");

            entity.HasOne(d => d.ListingType).WithMany(p => p.Listings)
                .HasForeignKey(d => d.ListingTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Listing__Listing__6754599E");

            entity.HasOne(d => d.Property).WithMany(p => p.Listings)
                .HasForeignKey(d => d.PropertyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Listing__Propert__66603565");
        });

        modelBuilder.Entity<ListingType>(entity =>
        {
            entity.HasKey(e => e.ListingTypeId).HasName("PK__ListingT__DE6DAC267A150410");

            entity.ToTable("ListingType");

            entity.Property(e => e.ListingTypeId).HasColumnName("ListingTypeID");
            entity.Property(e => e.ListingTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Municipality>(entity =>
        {
            entity.HasKey(e => e.MunicipalityId).HasName("PK__Municipa__009B60F53C35B207");

            entity.ToTable("Municipality");

            entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");
            entity.Property(e => e.MunicipalityName).HasMaxLength(100);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

            entity.HasOne(d => d.Province).WithMany(p => p.Municipalities)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Municipal__Provi__48CFD27E");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Person__AA2FFB85C6B6EB19");

            entity.ToTable("Person");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.EmailPerson).HasMaxLength(100);
            entity.Property(e => e.FirstNamePerson).HasMaxLength(50);
            entity.Property(e => e.LastNamePerson).HasMaxLength(50);
            entity.Property(e => e.PhonePerson).HasMaxLength(20);

            entity.HasOne(d => d.Address).WithMany(p => p.People)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Person__AddressI__5629CD9C");
        });

        modelBuilder.Entity<Photo>(entity =>
        {
            entity.HasKey(e => e.PhotoId).HasName("PK__Photo__21B7B58281CD5043");

            entity.ToTable("Photo");

            entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            entity.Property(e => e.PhotoUrl)
                .HasMaxLength(255)
                .HasColumnName("PhotoURL");
            entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

            entity.HasOne(d => d.Property).WithMany(p => p.Photos)
                .HasForeignKey(d => d.PropertyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Photo__PropertyI__6383C8BA");
        });

        modelBuilder.Entity<PostalCode>(entity =>
        {
            entity.HasKey(e => e.PostalCodeId).HasName("PK__PostalCo__E197FE61092D9E82");

            entity.ToTable("PostalCode");

            entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");
            entity.Property(e => e.MunicipalityId).HasColumnName("MunicipalityID");
            entity.Property(e => e.PostalCode1)
                .HasMaxLength(20)
                .HasColumnName("PostalCode");

            entity.HasOne(d => d.Municipality).WithMany(p => p.PostalCodes)
                .HasForeignKey(d => d.MunicipalityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PostalCod__Munic__4BAC3F29");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("PK__Property__70C9A75592087925");

            entity.ToTable("Property");

            entity.Property(e => e.PropertyId).HasColumnName("PropertyID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.PropertyTitle).HasMaxLength(255);
            entity.Property(e => e.PropertyTypeId).HasColumnName("PropertyTypeID");

            entity.HasOne(d => d.Address).WithMany(p => p.Properties)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Property__Addres__5DCAEF64");

            entity.HasOne(d => d.Person).WithMany(p => p.Properties)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Property__Person__5BE2A6F2");

            entity.HasOne(d => d.PropertyType).WithMany(p => p.Properties)
                .HasForeignKey(d => d.PropertyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Property__Proper__5CD6CB2B");
        });

        modelBuilder.Entity<PropertyDetail>(entity =>
        {
            entity.HasKey(e => e.PropertyDetailId).HasName("PK__Property__78ECFFBD5BE5D1D9");

            entity.ToTable("PropertyDetail");

            entity.Property(e => e.PropertyDetailId).HasColumnName("PropertyDetailID");
            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.EnergyClass).HasMaxLength(20);
            entity.Property(e => e.HeatingType).HasMaxLength(50);
            entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

            entity.HasOne(d => d.Property).WithMany(p => p.PropertyDetails)
                .HasForeignKey(d => d.PropertyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PropertyD__Prope__60A75C0F");
        });

        modelBuilder.Entity<PropertyType>(entity =>
        {
            entity.HasKey(e => e.PropertyTypeId).HasName("PK__Property__BDE14DD4B0EAD22C");

            entity.ToTable("PropertyType");

            entity.Property(e => e.PropertyTypeId).HasColumnName("PropertyTypeID");
            entity.Property(e => e.PropertyTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK__Province__FD0A6FA376923BC4");

            entity.ToTable("Province");

            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.ProvinceName).HasMaxLength(100);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Provinces)
                .HasForeignKey(d => d.RegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Province__Region__45F365D3");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Region__ACD844430D44B3F0");

            entity.ToTable("Region");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.RegionName).HasMaxLength(100);

            entity.HasOne(d => d.Country).WithMany(p => p.Regions)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Region__CountryI__4316F928");
        });

        modelBuilder.Entity<StepType>(entity =>
        {
            entity.HasKey(e => e.StepTypeId).HasName("PK__StepType__EEAE67D4EF7296E3");

            entity.ToTable("StepType");

            entity.Property(e => e.StepTypeId).HasColumnName("StepTypeID");
            entity.Property(e => e.StepTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.StreetId).HasName("PK__Street__6270EB1A4CA9F308");

            entity.ToTable("Street");

            entity.Property(e => e.StreetId).HasColumnName("StreetID");
            entity.Property(e => e.PostalCodeId).HasColumnName("PostalCodeID");
            entity.Property(e => e.StreetName).HasMaxLength(100);

            entity.HasOne(d => d.PostalCode).WithMany(p => p.Streets)
                .HasForeignKey(d => d.PostalCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Street__PostalCo__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
