using System;

namespace MyProject.Web.Core.Models
{
    public class Banana
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Length { get; set; }
    }
}