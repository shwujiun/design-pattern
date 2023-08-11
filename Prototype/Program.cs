// See https://aka.ms/new-console-template for more information
using Prototype;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");



ConcreatePrototype p1 = new ConcreatePrototype("123");
ConcreatePrototype c = (ConcreatePrototype)p1.Clone();
Console.WriteLine("clone id:"+ c.Id);


var resume = new Resume("大鳥");
resume.setPersonInfo("男", "xiaoming@abc.xyz");
resume.setWork("xxx公司", "1990~2000");
resume.display();
var resume1 = (Resume)resume.Clone();
resume1.setWork("xxx企业", "1998~1999");
resume1.display();
var resume2 = (Resume)resume.Clone();
resume2.setPersonInfo("xiaohong", "xiaohong@abc.xyz");
resume2.display();


var dr1 = new DeepResume("大鳥");
dr1.setPersonInfo("男", "xiaoming@abc.xyz");
dr1.setWork("xxx公司", "1990~2000");
dr1.display();
var dr2 = (Resume)resume.Clone();
dr2.setWork("xxx企业", "1998~1999");
dr2.display();
var dr3 = (Resume)resume.Clone();
dr3.setPersonInfo("xiaohong", "xiaohong@abc.xyz");
dr3.display();