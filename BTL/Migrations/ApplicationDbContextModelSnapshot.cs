﻿// <auto-generated />
using BTL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BTL.Models.NhaCungCap", b =>
                {
                    b.Property<string>("MaNhaCungCap")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SdtNhaCungCap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhaCungCap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhaCungCap");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("BTL.Models.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("ChucVu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MucLuong")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("BTL.Models.NhomThuoc", b =>
                {
                    b.Property<string>("MaNhomThuoc")
                        .HasColumnType("TEXT");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNhomThuoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhomThuoc");

                    b.ToTable("NhomThuoc");
                });

            modelBuilder.Entity("BTL.Models.Thuoc", b =>
                {
                    b.Property<string>("MaThuoc")
                        .HasColumnType("TEXT");

                    b.Property<string>("CongDung")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GiaBan")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NhaCungCap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NhomThuoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenThuoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaThuoc");

                    b.ToTable("Thuoc");
                });
#pragma warning restore 612, 618
        }
    }
}
