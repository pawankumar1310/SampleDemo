using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleDemo.Models;

public partial class StudentOriginal
{
   [Required(ErrorMessage = "StudentId can not be null")]
    public string StudentId { get; set; } = null!;

    [Required(ErrorMessage = "Gender is must")]
    [StringLength(1, ErrorMessage = "Gender Length must be 1. For male 'M', for female 'F' and so on....")]
    public string? Gender { get; set; }

    [Required]
    public string? NationalIty { get; set; }

    [Required]
    public string? PlaceofBirth { get; set; }

    [Required]
    public string? StageId { get; set; }

    [Required]
    public decimal? GradeId { get; set; }

    [Required]
    public string? SectionId { get; set; }
    [Required]

    public string? Topic { get; set; }
    [Required]
    public string? Semester { get; set; }

    [Required]
    public string? Relation { get; set; }

    public byte? Raisedhands { get; set; }

    public byte? VisItedResources { get; set; }

    public byte? AnnouncementsView { get; set; }

    public byte? Discussion { get; set; }

    public bool? ParentAnsweringSurvey { get; set; }

    public string? ParentschoolSatisfaction { get; set; }

    public string? StudentAbsenceDays { get; set; }

    public byte? StudentMarks { get; set; }

    [Required]
    public string? Class { get; set; }
}
