using System;
using System.Collections.Generic;

namespace SampleDemo.Models;

public partial class StudentOriginal
{
    public string StudentId { get; set; } = null!;

    public string? Gender { get; set; }

    public string? NationalIty { get; set; }

    public string? PlaceofBirth { get; set; }

    public string? StageId { get; set; }

    public decimal? GradeId { get; set; }

    public string? SectionId { get; set; }

    public string? Topic { get; set; }

    public string? Semester { get; set; }

    public string? Relation { get; set; }

    public byte? Raisedhands { get; set; }

    public byte? VisItedResources { get; set; }

    public byte? AnnouncementsView { get; set; }

    public byte? Discussion { get; set; }

    public bool? ParentAnsweringSurvey { get; set; }

    public string? ParentschoolSatisfaction { get; set; }

    public string? StudentAbsenceDays { get; set; }

    public byte? StudentMarks { get; set; }

    public string? Class { get; set; }
}
