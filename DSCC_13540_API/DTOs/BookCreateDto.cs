﻿namespace DSCC_13540_API.DTOs
{
    public class BookCreateDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }
    }
}