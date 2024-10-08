﻿// <auto-generated />
using System;
using admin_backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommonLibrary.Migrations
{
    [DbContext(typeof(MysqlDbContext))]
    [Migration("20240729110118_AddRolePermission")]
    partial class AddRolePermission
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CommonLibrary.Entities.AdSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("名稱");

                    b.Property<string>("PhotoMobile")
                        .HasColumnType("longtext")
                        .HasComment("手機圖片");

                    b.Property<string>("PhotoPc")
                        .HasColumnType("longtext")
                        .HasComment("PC圖片");

                    b.Property<int>("Position")
                        .HasColumnType("int")
                        .HasComment("廣告位置 1 = 橫幅, 2 = 首頁");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.Property<int>("Website")
                        .HasColumnType("int")
                        .HasComment("站台 1 = 林業自然保育署, 2 = 林業試驗所");

                    b.HasKey("Id");

                    b.ToTable("AdSetting");
                });

            modelBuilder.Entity("CommonLibrary.Entities.AdminUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("帳號");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("信箱");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime(6)")
                        .HasComment("登入時間");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasComment("姓名");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("密碼");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("照片");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasComment("角色");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AdminUser");
                });

            modelBuilder.Entity("CommonLibrary.Entities.CommonPest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ControlRecommendations")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("防治建議");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("DamageCharacteristics")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("危害特徵");

                    b.Property<int>("DamageClassId")
                        .HasColumnType("int")
                        .HasComment("危害種類");

                    b.Property<string>("DamagePart")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("危害部位 2 = 侵害土壤部, 3 = 樹幹, 5 = 樹枝, 6 = 樹葉, 7 = 花, 9 = 全面異常症狀病害");

                    b.Property<int>("DamageTypeId")
                        .HasColumnType("int")
                        .HasComment("危害類型");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("病蟲危害名稱");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("病蟲封面圖片");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟");

                    b.Property<DateTime>("UnpublishDate")
                        .HasColumnType("datetime(6)")
                        .HasComment("下架日期");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.HasIndex("DamageClassId");

                    b.HasIndex("DamageTypeId");

                    b.ToTable("CommonPest");
                });

            modelBuilder.Entity("CommonLibrary.Entities.DamageClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<int>("DamageTypeId")
                        .HasColumnType("int")
                        .HasComment("危害類型ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("危害種類");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.HasIndex("DamageTypeId");

                    b.ToTable("DamageClass");
                });

            modelBuilder.Entity("CommonLibrary.Entities.DamageType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("危害類型");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("DamageType");
                });

            modelBuilder.Entity("CommonLibrary.Entities.Documentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("內容");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("使用條款類型 1 = 同意書, 2 = 使用說明");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("Documentation");
                });

            modelBuilder.Entity("CommonLibrary.Entities.EpidemicSummary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("內容");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("標題");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("EpidemicSummary");
                });

            modelBuilder.Entity("CommonLibrary.Entities.FAQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("答案");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("問題");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("CommonLibrary.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logger")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("CommonLibrary.Entities.MailConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("寄信帳號");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<int>("Encrypted")
                        .HasColumnType("int")
                        .HasComment("加密方式 1 = SSL, 2 = TSL");

                    b.Property<string>("Host")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("主機");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("顯示名稱");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("寄信密碼");

                    b.Property<byte>("Port")
                        .HasColumnType("tinyint unsigned")
                        .HasComment("Port");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("MailConfig");
                });

            modelBuilder.Entity("CommonLibrary.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("發佈內容");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)")
                        .HasComment("排程結束時間");

                    b.Property<bool>("Pinned")
                        .HasColumnType("tinyint(1)")
                        .HasComment("置頂");

                    b.Property<bool>("Schedule")
                        .HasColumnType("tinyint(1)")
                        .HasComment("是否開啟排程");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)")
                        .HasComment("排程開始時間");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("發佈狀態 0 = 未發佈, 1 = 發佈");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("標題");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("公告類型 一般公告 = 1, 重要公告 = 2, 活動公告 = 3, 跑馬燈 = 4");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.Property<int>("WebsiteReleases")
                        .HasColumnType("int")
                        .HasComment("發佈網站");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("CommonLibrary.Entities.OperationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminUserId")
                        .HasColumnType("int")
                        .HasComment("使用者ID");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("異動內容");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("IP");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("異動類型 新增 = 1, 指派 = 2, 編輯 = 3, 刪除 = 4");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.HasIndex("AdminUserId");

                    b.ToTable("OperationLog");
                });

            modelBuilder.Entity("CommonLibrary.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasComment("權限名稱");

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasComment("檢視 = 1, 新增 = 2, 指派 = 3, 編輯 = 4, 刪除 = 5");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("CommonLibrary.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("角色名稱");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CommonLibrary.Entities.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Add")
                        .HasColumnType("tinyint(1)")
                        .HasComment("新增");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<bool>("Delete")
                        .HasColumnType("tinyint(1)")
                        .HasComment("刪除");

                    b.Property<bool>("Edit")
                        .HasColumnType("tinyint(1)")
                        .HasComment("編輯");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasComment("選單名稱");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasComment("角色管理ID");

                    b.Property<bool>("Sign")
                        .HasColumnType("tinyint(1)")
                        .HasComment("指派");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.Property<bool>("View")
                        .HasColumnType("tinyint(1)")
                        .HasComment("檢視");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("CommonLibrary.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("帳號");

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasComment("建立日期");

                    b.Property<DateTime>("LoginTime")
                        .HasColumnType("datetime(6)")
                        .HasComment("最後登入時間");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasComment("使用者名稱");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("狀態 0 = 關閉, 1 = 開啟, 2 = 停用");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)")
                        .HasComment("更新時間");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CommonLibrary.Entities.AdminUser", b =>
                {
                    b.HasOne("CommonLibrary.Entities.Role", "Role")
                        .WithMany("AdminUser")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CommonLibrary.Entities.CommonPest", b =>
                {
                    b.HasOne("CommonLibrary.Entities.DamageClass", "DamageClass")
                        .WithMany()
                        .HasForeignKey("DamageClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CommonLibrary.Entities.DamageType", "DamageType")
                        .WithMany()
                        .HasForeignKey("DamageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DamageClass");

                    b.Navigation("DamageType");
                });

            modelBuilder.Entity("CommonLibrary.Entities.DamageClass", b =>
                {
                    b.HasOne("CommonLibrary.Entities.DamageType", "DamageType")
                        .WithMany()
                        .HasForeignKey("DamageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DamageType");
                });

            modelBuilder.Entity("CommonLibrary.Entities.OperationLog", b =>
                {
                    b.HasOne("CommonLibrary.Entities.AdminUser", "AdminUser")
                        .WithMany()
                        .HasForeignKey("AdminUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminUser");
                });

            modelBuilder.Entity("CommonLibrary.Entities.RolePermission", b =>
                {
                    b.HasOne("CommonLibrary.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("CommonLibrary.Entities.Role", b =>
                {
                    b.Navigation("AdminUser");
                });
#pragma warning restore 612, 618
        }
    }
}
