using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        // POST
        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        // DELETE
        public async Task<Comment?> DeleteAsync(int id)
        {
            var commentModel = await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);

            if (commentModel == null)
            {
                return null;
            }

            _context.Comments.Remove(commentModel);

            await _context.SaveChangesAsync();

            return commentModel;
        }

        // GETALL
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.Include(a => a.User).ToListAsync();
        }

        // GETBYID
        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.Include(a => a.User)
            .FirstOrDefaultAsync(c => c.Id == id);
        }

        // PUT
        public async Task<Comment?> UpdateAsync(int id, Comment commentModel)
        {
            var commentToUpdate = await _context.Comments.FindAsync(id);

            if (commentToUpdate == null)
            {
                return null;
            }

            commentToUpdate.Title = commentModel.Title;
            commentToUpdate.Content = commentModel.Content;

            await _context.SaveChangesAsync();

            return commentToUpdate;
        }
    }
}

