using InterviewProject.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class InterviewBaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        public InterviewBaseController(TRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> GetOne(int id)
        {
            return await repository.Get(id);
        }

        [HttpPut]
        public async Task<ActionResult<TEntity>> Update(TEntity entity)
        {
            return await repository.Update(entity);
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Create(TEntity entity)
        {
            return await repository.Add(entity);
        }

        [HttpDelete]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            return await repository.Delete(id);
        }
    }
}

