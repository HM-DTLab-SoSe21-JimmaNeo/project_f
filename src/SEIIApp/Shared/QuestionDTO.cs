﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEIIApp.Shared
{
  public class QuestionDTO
  {
    [Required(ErrorMessage = "Question is required")]
    [StringLength(2000, MinimumLength = 1)]
    public string QuestionText { get; set; }

    [ValidateComplexType]
    public List<AnswerDTO> Answers { get; set; }

    public string Explanation { get; set; }

    public List<PictureContentDTO> Pictures { get; set; }

  }
}
