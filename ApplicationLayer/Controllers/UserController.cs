using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApplicationLayer.Controllers
{
    [RoutePrefix("api")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("all-users")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("create-user")]
       public HttpResponseMessage Create(UserDTO userDTO)
        {
            try
            {
                var data = UserService.Create(userDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = UserService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPatch]
        [Route("update/{id}")]
        public HttpResponseMessage Update(int id, UserDTO updatedUser)
        {
            try
            {
                var data = UserService.Update(id, updatedUser);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = UserService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("bmi/{id}")]
        public HttpResponseMessage CalcBMI(int id)
        {
            try
            {
                var data = UserService.CalcBMI(id);
                if (data == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("recommendation/{id}")]
        public HttpResponseMessage GetRecommendation(int id)
        {
            try
            {
                var result = UserService.GetRecommendation(id);
                if (result == null)
                    return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");

                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("leaderboard")]
        public HttpResponseMessage GetLeaderboard()
        {
            try
            {
                List<UserLeaderboardDTO> leaderboard = UserService.GetLeaderboard();
                return Request.CreateResponse(HttpStatusCode.OK, leaderboard);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
