﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using NguyenHungCuong2011060110.DTOs;
using NguyenHungCuong2011060110.Models;

namespace NguyenHungCuong2011060110.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {

        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend (AttendanceDto attendanceDto)
        {
            var userId =User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeID == userId && a.CourseID == attendanceDto.CourseID))
                return BadRequest("The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseID = attendanceDto.CourseID,
                AttendeeID = userId

            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    
    }
}