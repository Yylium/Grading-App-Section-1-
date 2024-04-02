﻿// <auto-generated />
using System;
using Grading_App_Section_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Grading_App_Section_1.Migrations
{
    [DbContext(typeof(GradingAppContext))]
    [Migration("20240402010741_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Grading_App_Section_1.Models.Admins_Teacher", b =>
                {
                    b.Property<string>("prof_netid")
                        .HasColumnType("TEXT");

                    b.Property<string>("class_number")
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("prof_netid");

                    b.ToTable("Admins_Teachers");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Judge", b =>
                {
                    b.Property<int>("judge_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("judge_team_id")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("judge_id");

                    b.HasIndex("judge_team_id");

                    b.ToTable("Judges");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Judge_Team", b =>
                {
                    b.Property<int>("judge_team_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("judge_team_modifier")
                        .HasColumnType("INTEGER");

                    b.HasKey("judge_team_id");

                    b.ToTable("Judge_Teams");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Login_Table", b =>
                {
                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<string>("authorization_level")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password_hash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("username");

                    b.ToTable("Login_Tables");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Rubric_Item", b =>
                {
                    b.Property<int>("rubric_item_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Admins_Teacherprof_netid")
                        .HasColumnType("TEXT");

                    b.Property<int>("class_number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("max_points")
                        .HasColumnType("INTEGER");

                    b.Property<string>("rubric_item_details")
                        .HasColumnType("TEXT");

                    b.Property<string>("rubric_item_text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("rubric_item_id");

                    b.HasIndex("Admins_Teacherprof_netid");

                    b.ToTable("Rubric_Items");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Rubric_Item_Grade", b =>
                {
                    b.Property<int>("grade_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Student_Groupgroup_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("group_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("rubric_item_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("rubric_item_score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ta_comment")
                        .HasColumnType("TEXT");

                    b.HasKey("grade_id");

                    b.HasIndex("Student_Groupgroup_id");

                    b.ToTable("Rubric_Item_Grades");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Schedule", b =>
                {
                    b.Property<int>("schedule_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Student_Groupgroup_id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("group_id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("judge_team_id")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("schedule_room")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("schedule_time")
                        .HasColumnType("INTEGER");

                    b.HasKey("schedule_id");

                    b.HasIndex("Student_Groupgroup_id");

                    b.HasIndex("judge_team_id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Student", b =>
                {
                    b.Property<int>("student_netid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Student_Groupgroup_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("group_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("student_modifier")
                        .HasColumnType("INTEGER");

                    b.HasKey("student_netid");

                    b.HasIndex("Student_Groupgroup_id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Student_Group", b =>
                {
                    b.Property<int>("group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("group_modifier")
                        .HasColumnType("INTEGER");

                    b.Property<int>("group_number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("section_number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("submission_link")
                        .HasColumnType("TEXT");

                    b.HasKey("group_id");

                    b.ToTable("Student_Groups");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Survey_Response", b =>
                {
                    b.Property<int>("survey_response_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Student_Groupgroup_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("group_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("judge_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("question_id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("survey_num_response")
                        .HasColumnType("INTEGER");

                    b.Property<string>("survey_text_response")
                        .HasColumnType("TEXT");

                    b.HasKey("survey_response_id");

                    b.HasIndex("Student_Groupgroup_id");

                    b.HasIndex("judge_id");

                    b.ToTable("Survey_Responses");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.TA", b =>
                {
                    b.Property<string>("ta_netid")
                        .HasColumnType("TEXT");

                    b.Property<string>("Admins_Teacherprof_netid")
                        .HasColumnType("TEXT");

                    b.Property<int>("class_number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ta_netid");

                    b.HasIndex("Admins_Teacherprof_netid");

                    b.ToTable("TAs");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Judge", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Judge_Team", "Judge_Team")
                        .WithMany()
                        .HasForeignKey("judge_team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Judge_Team");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Rubric_Item", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Admins_Teacher", "Admins_Teacher")
                        .WithMany()
                        .HasForeignKey("Admins_Teacherprof_netid");

                    b.Navigation("Admins_Teacher");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Rubric_Item_Grade", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Student_Group", "Student_Group")
                        .WithMany()
                        .HasForeignKey("Student_Groupgroup_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student_Group");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Schedule", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Student_Group", "Student_Group")
                        .WithMany()
                        .HasForeignKey("Student_Groupgroup_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Grading_App_Section_1.Models.Judge_Team", "Judge_Team")
                        .WithMany()
                        .HasForeignKey("judge_team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Judge_Team");

                    b.Navigation("Student_Group");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Student", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Student_Group", "Student_Group")
                        .WithMany()
                        .HasForeignKey("Student_Groupgroup_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student_Group");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.Survey_Response", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Student_Group", "Student_Group")
                        .WithMany()
                        .HasForeignKey("Student_Groupgroup_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Grading_App_Section_1.Models.Judge", "Judge")
                        .WithMany()
                        .HasForeignKey("judge_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Judge");

                    b.Navigation("Student_Group");
                });

            modelBuilder.Entity("Grading_App_Section_1.Models.TA", b =>
                {
                    b.HasOne("Grading_App_Section_1.Models.Admins_Teacher", "Admins_Teacher")
                        .WithMany()
                        .HasForeignKey("Admins_Teacherprof_netid");

                    b.Navigation("Admins_Teacher");
                });
#pragma warning restore 612, 618
        }
    }
}
