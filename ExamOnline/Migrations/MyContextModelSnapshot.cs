﻿// <auto-generated />
using System;
using ExamOnline.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamOnline.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamOnline.Models.Answer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answers");

                    b.Property<string>("QuestionId");

                    b.Property<bool>("Status");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("tb_t_answer");
                });

            modelBuilder.Entity("ExamOnline.Models.EventDetails", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("eventsId");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.HasIndex("eventsId");

                    b.ToTable("tb_t_event_details");
                });

            modelBuilder.Entity("ExamOnline.Models.Events", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("tb_m_events");
                });

            modelBuilder.Entity("ExamOnline.Models.Question", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Key");

                    b.Property<string>("OptionA");

                    b.Property<string>("OptionB");

                    b.Property<string>("OptionC");

                    b.Property<string>("OptionD");

                    b.Property<string>("OptionE");

                    b.Property<string>("Questions");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("tb_m_question");
                });

            modelBuilder.Entity("ExamOnline.Models.Subjects", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isDelete");

                    b.HasKey("Id");

                    b.ToTable("tb_m_subjects");
                });

            modelBuilder.Entity("ExamOnline.Models.Answer", b =>
                {
                    b.HasOne("ExamOnline.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("ExamOnline.Models.EventDetails", b =>
                {
                    b.HasOne("ExamOnline.Models.Events", "events")
                        .WithMany()
                        .HasForeignKey("eventsId");
                });
#pragma warning restore 612, 618
        }
    }
}
