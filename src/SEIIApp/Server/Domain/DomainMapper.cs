using AutoMapper;
using SEIIApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEIIApp.Server.Domain
{
    public class DomainMapper : Profile
    {

        public DomainMapper()
        {

            // Answer
            CreateMap<Answer, AnswerDTO>();
            CreateMap<AnswerDTO, Answer>();

            // FurtherLink
            CreateMap<FurtherLink, FurtherLinkDTO>();
            CreateMap<FurtherLinkDTO, FurtherLink>();

            // YT-Videos
            CreateMap<VideoContent, VideoContentDTO>();
            CreateMap<VideoContentDTO, VideoContent>();

            // LectureContent
            CreateMap<LectureContent, LectureContentDTO>();
            CreateMap<LectureContentDTO, LectureContent>();

            // Lecture
            CreateMap<Lecture, LectureDTO>();
            CreateMap<LectureDTO, Lecture>(); 

            CreateMap<Lecture, LectureBaseDTO>();
            CreateMap<LectureBaseDTO, Lecture>();

            // News
            CreateMap<News , NewsDTO>();
            CreateMap<NewsDTO, News>();

            // Question
            CreateMap<Question, QuestionDTO>();
            CreateMap<QuestionDTO, Question>();

            // SubjectArea
            CreateMap<SubjectArea, SubjectAreaDTO>()
                .ForMember(subjectAreaDto => subjectAreaDto.Lectures, opts => opts.MapFrom(obj => obj.Lectures.ToList()));
            CreateMap<SubjectAreaDTO, SubjectArea>()
                .ForMember(subjectAreaObj => subjectAreaObj.Lectures, opts => opts.MapFrom(obj => obj.Lectures.ToList()));

            // TestContent
            CreateMap<TestContent, TestContentDTO>();
            CreateMap<TestContentDTO, TestContent>();

            // Test
            CreateMap<Test, TestDTO>();
            CreateMap<TestDTO, Test>();

            CreateMap<Test, TestBaseDTO>();
            CreateMap<TestBaseDTO, Test>();


            //CompletedTest
            CreateMap<CompletedTest, CompletedTestDTO>();
            CreateMap<CompletedTestDTO, CompletedTest>();

            // User
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();

        }

    }
}
