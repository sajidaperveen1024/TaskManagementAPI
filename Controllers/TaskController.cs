using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using TaskManagementAPI.Interfaces;
using TaskManagementAPI.Models.DTOs;
using TaskManagementAPI.Models.Tables;

namespace TaskManagementAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {

        private readonly ITaskService _taskService;

        /// <summary>
        /// Constructor to initialize the controller with a user task service.
        /// </summary>
        /// <param name="userTaskService">The service for managing user tasks.</param>
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        /// <summary>
        /// Endpoint to get all tasks.
        /// </summary>
        [HttpGet("get-all-task")]
        [SwaggerOperation(Summary = "Get all tasks", Description = "Retrieve a list of all tasks.")]
        public async Task<IActionResult> GetTasks()
        {
            // Call the service to get all tasks.
            var response = await _taskService.GetTasks();

            // Return the response with the appropriate status code.
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// Endpoint to get a task by its ID.
        /// </summary>
        /// <param name="input">DTO containing the task ID.</param>
        [HttpPost("get-task-by-id")]
        [SwaggerOperation(Summary = "Get task by ID", Description = "Retrieve a task by its ID.")]
        public async Task<IActionResult> GetTask([FromBody] GetTaskDto input)
        {
            // Call the service to get a task by ID.
            var response = await _taskService.GetTaskById(input.Id);

            // Return the response with the appropriate status code.
            return StatusCode(response.StatusCode, response);
        }

        /// <summary>
        /// Endpoint to update a task.
        /// </summary>
        /// <param name="task">The updated UserTask object.</param>
        [HttpPatch("update-task")]
        [SwaggerOperation(Summary = "Update task", Description = "Update an existing task.")]
        public async Task<IActionResult> UpdateTask([FromBody] UserTask task)
        {
            // Call the service to update the task.
            var response = await _taskService.UpdateTask(task);
            // Return the response with the appropriate status code.
            return StatusCode(response.StatusCode, response);

        }

        /// <summary>
        /// Endpoint to create a new task.
        /// </summary>
        /// <param name="task">The UserTask object representing the new task.</param>
        [HttpPost("create-task")]
        [SwaggerOperation(Summary = "Create task", Description = "Create a new task.")]
        public async Task<IActionResult> CreateTask([FromBody] UserTask task)
        {
            // Call the service to create a new task.
            var response = await _taskService.CreateTask(task);

            // Return the response with the appropriate status code.
            return StatusCode(response.StatusCode, response);

        }


        /// <summary>
        /// Endpoint to delete a task by its ID.
        /// </summary>
        /// <param name="input">DTO containing the task ID to be deleted.</param>
        [HttpDelete("delete-task-by-id")]
        [SwaggerOperation(Summary = "Delete task by ID", Description = "Delete a task by its ID.")]
        public async Task<IActionResult> DeleteTask([FromBody] DeleteTaskDTO input)
        {
            // Call the service to delete the task by ID.
            var response = await _taskService.DeleteTask(input.Id);

            // Return the response with the appropriate status code.
            return StatusCode(response.StatusCode, response);
        }
    }
    
    }


   

