﻿using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Grading_App_Section_1.Controllers
{
    public class StudentController : Controller
    {
        private IGradingAppRepository _repo;

        public StudentController(IGradingAppRepository temp)
        {
            _repo = temp;
        }
        
        [HttpGet]
        public IActionResult LinkSubmission()
        {
            var netid = "ctg34";
            
            var creed = _repo.Students
                .Where(x => x.student_netid == netid)
                .FirstOrDefault();
            return View("~/Views/Student/LinkSubmission.cshtml", creed);
        }

        [HttpPost]
        public IActionResult LinkSubmission(Student_Group student_group, string submissionLink, int groupId)
        {

            if (ModelState.IsValid)
            {
                _repo.AddLink(student_group);
            }

            return View();

            //var group = new Student_Group
            //{
            //    group_id = groupId,
            //    submission_link = submissionLink
            //};
            //_repo.Student_Groups.Add(group);
            ////_repo.SaveChanges();


            //return RedirectToAction("LinkSubmission"); 
        }
        
        // Build Controllers for Edit and Delete
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.Student_Groups
                .Single(x => x.group_id == id);
            
            return View("~/Views/Student/Edit.cshtml");
        }

        [HttpPost]
        public IActionResult Edit(Student_Group groupInfo)
        {
            if (ModelState.IsValid)
            {
                //_repo.Student_Groups.Update(groupInfo);
                return View("~/Views/Student/Edit.cshtml");
            }
            
            return RedirectToAction("LinkSubmission");
        }

        public IActionResult InfoPage(string netid)
        {
            var studentinfo = _repo.Students.FirstOrDefault(s => s.student_netid == netid);
            var groupId = studentinfo.group_id;
            var groupsinfo = _repo.Student_Groups.FirstOrDefault(g => g.group_id == groupId);

            var info = new Student
            {
                first_name = studentinfo.first_name,
                group_id = studentinfo.group_id,
                last_name = studentinfo.last_name,
                Student_Group = new Student_Group
                {
                    group_id = groupsinfo.group_id,
                    group_modifier = groupsinfo.group_modifier,
                    group_number = groupsinfo.group_number,
                    section_number = groupsinfo.section_number,
                    submission_link = groupsinfo.submission_link

                },
                student_modifier = studentinfo.student_modifier,
                student_netid = studentinfo.student_netid
            };
            
            return View("~/Views/Student/InfoPage.cshtml", info);
        }
    }
}
