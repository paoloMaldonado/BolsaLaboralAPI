using System;
using BolsaLaboralWeb.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BolsaLaboralWeb.Domain.Infrastructure.Data
{
    public partial class Bolsa_LaboralContext : DbContext
    {
        public Bolsa_LaboralContext()
        {
        }

        public Bolsa_LaboralContext(DbContextOptions<Bolsa_LaboralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoriaEmpleo> CategoriaEmpleo { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<HojaVidaCv> HojaVidaCv { get; set; }
        public virtual DbSet<NivelExperiencia> NivelExperiencia { get; set; }
        public virtual DbSet<OfertaLaboral> OfertaLaboral { get; set; }
        public virtual DbSet<Postulante> Postulante { get; set; }
        public virtual DbSet<PostularOferta> PostularOferta { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LEGION-5I;Database=Bolsa_Laboral;MultipleActiveResultSets=true;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CategoriaEmpleo>(entity =>
            {
                entity.HasKey(e => e.IdCatEmpleo)
                    .HasName("pk_id_cat_empleo");

                entity.ToTable("categoria_empleo");

                entity.Property(e => e.IdCatEmpleo).HasColumnName("id_cat_empleo");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("categoria");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("pk_id_departamento");

                entity.ToTable("departamento");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("pk_id_empresa");

                entity.ToTable("empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_name");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.IdSector1).HasColumnName("id_sector1");

                entity.Property(e => e.IdUbigeo1).HasColumnName("id_ubigeo1");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.RazonSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("razon_social");

                entity.Property(e => e.ReferenciaUbigeo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("referencia_ubigeo");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ruc");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("website");

                entity.HasOne(d => d.IdSector1Navigation)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.IdSector1)
                    .HasConstraintName("fk_id_sector1");

                entity.HasOne(d => d.IdUbigeo1Navigation)
                    .WithMany(p => p.Empresa)
                    .HasForeignKey(d => d.IdUbigeo1)
                    .HasConstraintName("fk_id_ubigeo1");
            });

            modelBuilder.Entity<Especialidad>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad)
                    .HasName("pk_id_especialidad");

                entity.ToTable("especialidad");

                entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<HojaVidaCv>(entity =>
            {
                entity.HasKey(e => e.IdHojaVida)
                    .HasName("pk_id_hoja_vida");

                entity.ToTable("hoja_vida_cv");

                entity.Property(e => e.IdHojaVida).HasColumnName("id_hoja_vida");

                entity.Property(e => e.AnioExp)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("anio_exp");

                entity.Property(e => e.BuscaTrabajo).HasColumnName("busca_trabajo");

                entity.Property(e => e.CentroEducativo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("centro_educativo");

                entity.Property(e => e.Empresa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empresa");

                entity.Property(e => e.ExamenInter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("examen_inter");

                entity.Property(e => e.FechaFinEstudio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_fin_estudio");

                entity.Property(e => e.FechaFinJob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_fin_job");

                entity.Property(e => e.FechaIniEstudio)
                    .HasColumnType("date")
                    .HasColumnName("fecha_ini_estudio");

                entity.Property(e => e.FechaIniJob)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fecha_ini_job");

                entity.Property(e => e.GradoInstruccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grado_instruccion");

                entity.Property(e => e.IdEspecialidad1).HasColumnName("id_especialidad1");

                entity.Property(e => e.IdNivelExperiencia2).HasColumnName("id_nivel_experiencia2");

                entity.Property(e => e.IdPuestoPref)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_puesto_pref");

                entity.Property(e => e.NivelIngles)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivel_ingles");

                entity.Property(e => e.ObjetivosMotivavion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("objetivos_motivavion");

                entity.Property(e => e.Puesto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("puesto");

                entity.Property(e => e.TieneTrabajo).HasColumnName("tiene_trabajo");

                entity.HasOne(d => d.IdEspecialidad1Navigation)
                    .WithMany(p => p.HojaVidaCv)
                    .HasForeignKey(d => d.IdEspecialidad1)
                    .HasConstraintName("fk_id_especialidad1");

                entity.HasOne(d => d.IdNivelExperiencia2Navigation)
                    .WithMany(p => p.HojaVidaCv)
                    .HasForeignKey(d => d.IdNivelExperiencia2)
                    .HasConstraintName("fk_id_nivel_experiencia2");
            });

            modelBuilder.Entity<NivelExperiencia>(entity =>
            {
                entity.HasKey(e => e.IdNivelExperiencia)
                    .HasName("pk_id_nivel_experiencia");

                entity.ToTable("nivel_experiencia");

                entity.Property(e => e.IdNivelExperiencia).HasColumnName("id_nivel_experiencia");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<OfertaLaboral>(entity =>
            {
                entity.HasKey(e => e.IdOferta)
                    .HasName("pk_id_oferta");

                entity.ToTable("oferta_laboral");

                entity.Property(e => e.IdOferta).HasColumnName("id_oferta");

                entity.Property(e => e.Beneficios)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("beneficios");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_publicacion");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_vencimiento");

                entity.Property(e => e.IdCatEmpleo1).HasColumnName("id_cat_empleo1");

                entity.Property(e => e.IdEmpresa1).HasColumnName("id_empresa1");

                entity.Property(e => e.IdNivelExperiencia1).HasColumnName("id_nivel_experiencia1");

                entity.Property(e => e.IdUbigeo3).HasColumnName("id_ubigeo3");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdCatEmpleo1Navigation)
                    .WithMany(p => p.OfertaLaboral)
                    .HasForeignKey(d => d.IdCatEmpleo1)
                    .HasConstraintName("fk_id_cat_empleo1");

                entity.HasOne(d => d.IdEmpresa1Navigation)
                    .WithMany(p => p.OfertaLaboral)
                    .HasForeignKey(d => d.IdEmpresa1)
                    .HasConstraintName("fk_id_empresa1");

                entity.HasOne(d => d.IdNivelExperiencia1Navigation)
                    .WithMany(p => p.OfertaLaboral)
                    .HasForeignKey(d => d.IdNivelExperiencia1)
                    .HasConstraintName("fk_id_nivel_experiencia1");

                entity.HasOne(d => d.IdUbigeo3Navigation)
                    .WithMany(p => p.OfertaLaboral)
                    .HasForeignKey(d => d.IdUbigeo3)
                    .HasConstraintName("fk_id_ubigeo3");
            });

            modelBuilder.Entity<Postulante>(entity =>
            {
                entity.HasKey(e => e.IdPostulante)
                    .HasName("pk_id_postulante");

                entity.ToTable("postulante");

                entity.Property(e => e.IdPostulante).HasColumnName("id_postulante");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Genero)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.IdCvVirtual).HasColumnName("id_cv_virtual");

                entity.Property(e => e.IdUbigeo2).HasColumnName("id_ubigeo2");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.TieneEstudio).HasColumnName("tiene_estudio");

                entity.Property(e => e.TieneExperiencia).HasColumnName("tiene_experiencia");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zip_code");

                entity.HasOne(d => d.IdCvVirtualNavigation)
                    .WithMany(p => p.Postulante)
                    .HasForeignKey(d => d.IdCvVirtual)
                    .HasConstraintName("fk_id_cv_virtual");

                entity.HasOne(d => d.IdUbigeo2Navigation)
                    .WithMany(p => p.Postulante)
                    .HasForeignKey(d => d.IdUbigeo2)
                    .HasConstraintName("fk_id_ubigeo2");
            });

            modelBuilder.Entity<PostularOferta>(entity =>
            {
                entity.HasKey(e => e.IdPostular)
                    .HasName("pk_id_postular");

                entity.ToTable("postular_oferta");

                entity.Property(e => e.IdPostular).HasColumnName("id_postular");

                entity.Property(e => e.CvAdjunto)
                    .IsUnicode(false)
                    .HasColumnName("cv_adjunto");

                entity.Property(e => e.Estado)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaFinalizado)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_finalizado");

                entity.Property(e => e.FechaPostulacion)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha_postulacion");

                entity.Property(e => e.IdOferta1).HasColumnName("id_oferta1");

                entity.Property(e => e.IdPostulante1).HasColumnName("id_postulante1");

                entity.HasOne(d => d.IdOferta1Navigation)
                    .WithMany(p => p.PostularOferta)
                    .HasForeignKey(d => d.IdOferta1)
                    .HasConstraintName("fk_id_oferta1");

                entity.HasOne(d => d.IdPostulante1Navigation)
                    .WithMany(p => p.PostularOferta)
                    .HasForeignKey(d => d.IdPostulante1)
                    .HasConstraintName("fk_id_postulante1");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.IdProvincia)
                    .HasName("pk_id_provincia");

                entity.ToTable("provincia");

                entity.Property(e => e.IdProvincia).HasColumnName("id_provincia");

                entity.Property(e => e.IdDepartamento1).HasColumnName("id_departamento1");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdDepartamento1Navigation)
                    .WithMany(p => p.Provincia)
                    .HasForeignKey(d => d.IdDepartamento1)
                    .HasConstraintName("fk_id_departamento1");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.IdSector)
                    .HasName("pk_id_sector");

                entity.ToTable("sector");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Ubigeo>(entity =>
            {
                entity.HasKey(e => e.IdUbigeo)
                    .HasName("pk_id_ubigeo");

                entity.ToTable("ubigeo");

                entity.Property(e => e.IdUbigeo).HasColumnName("id_ubigeo");

                entity.Property(e => e.IdDepartamento3).HasColumnName("id_departamento3");

                entity.Property(e => e.IdProvincia2).HasColumnName("id_provincia2");

                entity.HasOne(d => d.IdDepartamento3Navigation)
                    .WithMany(p => p.Ubigeo)
                    .HasForeignKey(d => d.IdDepartamento3)
                    .HasConstraintName("fk_id_departamento3");

                entity.HasOne(d => d.IdProvincia2Navigation)
                    .WithMany(p => p.Ubigeo)
                    .HasForeignKey(d => d.IdProvincia2)
                    .HasConstraintName("fk_id_provincia2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
