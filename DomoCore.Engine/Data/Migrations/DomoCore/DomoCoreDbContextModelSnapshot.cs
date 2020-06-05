﻿// <auto-generated />
using System;
using DomoCore.Engine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DomoCore.Engine.Data.Migrations.DomoCore
{
    [DbContext(typeof(DomoCoreDbContext))]
    partial class DomoCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("DomoCore.Engine.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "192.168.0.236",
                            Name = "Domo1"
                        });
                });

            modelBuilder.Entity("DomoCore.Engine.Models.FollowerOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("InputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OutputId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InputId");

                    b.HasIndex("OutputId");

                    b.ToTable("FollowerOutputs");
                });

            modelBuilder.Entity("DomoCore.Engine.Models.Input", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Changed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrentState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HWValue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PreviousState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Inputs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 1,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 2,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 2,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 3,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 4,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 4,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 8,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 5,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 16,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 6,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 32,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 7,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 64,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 8,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 128,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 9,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 256,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 10,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 512,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 11,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 1024,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 12,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 2048,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 13,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 4096,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 14,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 8192,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 15,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 16384,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 16,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 32768,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 17,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 65536,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 18,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 131072,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 19,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 262144,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 20,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 524288,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 21,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 1048576,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 22,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 2097152,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 23,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 4194304,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 24,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 8388608,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 25,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 16777216,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 26,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 33554432,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 27,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 67108864,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 28,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 134217728,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 29,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 268435456,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 30,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 536870912,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 31,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = 1073741824,
                            PreviousState = "Released"
                        },
                        new
                        {
                            Id = 32,
                            Changed = false,
                            CurrentState = "Released",
                            DeviceId = 1,
                            HWValue = -2147483648,
                            PreviousState = "Released"
                        });
                });

            modelBuilder.Entity("DomoCore.Engine.Models.Output", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Changed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HWValue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Outputs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 128,
                            State = "Off"
                        },
                        new
                        {
                            Id = 2,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 64,
                            State = "Off"
                        },
                        new
                        {
                            Id = 3,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 32,
                            State = "Off"
                        },
                        new
                        {
                            Id = 4,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 16,
                            State = "Off"
                        },
                        new
                        {
                            Id = 5,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 8,
                            State = "Off"
                        },
                        new
                        {
                            Id = 6,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 4,
                            State = "Off"
                        },
                        new
                        {
                            Id = 7,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 2,
                            State = "Off"
                        },
                        new
                        {
                            Id = 8,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 1,
                            State = "Off"
                        },
                        new
                        {
                            Id = 9,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 32768,
                            State = "Off"
                        },
                        new
                        {
                            Id = 10,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 16384,
                            State = "Off"
                        },
                        new
                        {
                            Id = 11,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 8192,
                            State = "Off"
                        },
                        new
                        {
                            Id = 12,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 4096,
                            State = "Off"
                        },
                        new
                        {
                            Id = 13,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 2048,
                            State = "Off"
                        },
                        new
                        {
                            Id = 14,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 1024,
                            State = "Off"
                        },
                        new
                        {
                            Id = 15,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 512,
                            State = "Off"
                        },
                        new
                        {
                            Id = 16,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 256,
                            State = "Off"
                        },
                        new
                        {
                            Id = 17,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 8388608,
                            State = "Off"
                        },
                        new
                        {
                            Id = 18,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 4194304,
                            State = "Off"
                        },
                        new
                        {
                            Id = 19,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 2097152,
                            State = "Off"
                        },
                        new
                        {
                            Id = 20,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 1048576,
                            State = "Off"
                        },
                        new
                        {
                            Id = 21,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 524288,
                            State = "Off"
                        },
                        new
                        {
                            Id = 22,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 262144,
                            State = "Off"
                        },
                        new
                        {
                            Id = 23,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 131072,
                            State = "Off"
                        },
                        new
                        {
                            Id = 24,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 65536,
                            State = "Off"
                        },
                        new
                        {
                            Id = 25,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = -2147483648,
                            State = "Off"
                        },
                        new
                        {
                            Id = 26,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 1073741824,
                            State = "Off"
                        },
                        new
                        {
                            Id = 27,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 536870912,
                            State = "Off"
                        },
                        new
                        {
                            Id = 28,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 268435456,
                            State = "Off"
                        },
                        new
                        {
                            Id = 29,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 134217728,
                            State = "Off"
                        },
                        new
                        {
                            Id = 30,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 67108864,
                            State = "Off"
                        },
                        new
                        {
                            Id = 31,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 33554432,
                            State = "Off"
                        },
                        new
                        {
                            Id = 32,
                            Changed = false,
                            DeviceId = 1,
                            HWValue = 16777216,
                            State = "Off"
                        });
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SensorControlledOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AutoOff")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutoOffTimeSecs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OutputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InputId");

                    b.HasIndex("OutputId");

                    b.ToTable("SensorControlledOutputs");
                });

            modelBuilder.Entity("DomoCore.Engine.Models.ShutterOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Counter")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DirectionOutputId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PowerOutputId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RunTimeSecs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DirectionOutputId");

                    b.HasIndex("InputId");

                    b.HasIndex("PowerOutputId");

                    b.ToTable("ShutterOutputs");
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SimpleOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AutoOff")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutoOffTimeSecs")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OutputId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("InputId");

                    b.HasIndex("OutputId");

                    b.ToTable("SimpleOutputs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AutoOff = false,
                            AutoOffTimeSecs = 0,
                            InputId = 1,
                            Name = "Licht 1",
                            OutputId = 1,
                            State = "Off"
                        },
                        new
                        {
                            Id = 2,
                            AutoOff = false,
                            AutoOffTimeSecs = 0,
                            InputId = 2,
                            Name = "Licht 2",
                            OutputId = 2,
                            State = "Off"
                        });
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SwitchTime", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DayOfWeek")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Enabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Minute")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Second")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ShutterOutputId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShutterOutputdId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SimpleOutputId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SwitchOn")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ShutterOutputId");

                    b.HasIndex("SimpleOutputId");

                    b.ToTable("SwitchTimes");
                });

            modelBuilder.Entity("DomoCore.Engine.Models.FollowerOutput", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Input", "Input")
                        .WithMany()
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomoCore.Engine.Models.Output", "Output")
                        .WithMany()
                        .HasForeignKey("OutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.Input", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.Output", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SensorControlledOutput", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Input", "Input")
                        .WithMany()
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomoCore.Engine.Models.Output", "Output")
                        .WithMany()
                        .HasForeignKey("OutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.ShutterOutput", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Output", "DirectionOutput")
                        .WithMany()
                        .HasForeignKey("DirectionOutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomoCore.Engine.Models.Input", "Input")
                        .WithMany()
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomoCore.Engine.Models.Output", "PowerOutput")
                        .WithMany()
                        .HasForeignKey("PowerOutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SimpleOutput", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.Input", "Input")
                        .WithMany()
                        .HasForeignKey("InputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomoCore.Engine.Models.Output", "Output")
                        .WithMany()
                        .HasForeignKey("OutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DomoCore.Engine.Models.SwitchTime", b =>
                {
                    b.HasOne("DomoCore.Engine.Models.ShutterOutput", "ShutterOutput")
                        .WithMany("SwitchTimes")
                        .HasForeignKey("ShutterOutputId");

                    b.HasOne("DomoCore.Engine.Models.SimpleOutput", "SimpleOutput")
                        .WithMany("SwitchTimes")
                        .HasForeignKey("SimpleOutputId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
