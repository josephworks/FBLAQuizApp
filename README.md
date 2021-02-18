# FBLAQuizApp
An FBLA Quiz Software

## Framework

Refer to https://gallery.platform.uno/ for UI design.

Refer to https://docs.microsoft.com/en-us/windows/apps/fluent-design-system for UWP development.

## Database

```sql
CREATE TABLE [dbo].[Table]
(
    [Id] INT NOT NULL PRIMARY KEY, 
    [QuestionType] NTEXT NULL, 
    [Question] NTEXT NULL, 
    [CorrectAnswer] NTEXT NULL, 
    [Answer1] NTEXT NULL, 
    [Answer2] NTEXT NULL, 
    [Answer3] NTEXT NULL, 
    [Answer4] NTEXT NULL
)

INSERT INTO [dbo].[Table] ([Id], [QuestionType], [Question], [CorrectAnswer], [Answer1], [Answer2], [Answer3], [Answer4]) VALUES (1, N'Multiple Choice', N'What is the name of the FBLA division for post-secondary students?', N'Phi Beta Lambda
', N'Phi Beta Lambda
', N'Phi Alpha Lambda
', N'Alpha Beta Lambda
', N'Phi Lambda Beta
')
INSERT INTO [dbo].[Table] ([Id], [QuestionType], [Question], [CorrectAnswer], [Answer1], [Answer2], [Answer3], [Answer4]) VALUES (2, N'TrueFalse', N'The concept of FBLA was developed in 1937.
', N'True
', NULL, NULL, NULL, NULL)
INSERT INTO [dbo].[Table] ([Id], [QuestionType], [Question], [CorrectAnswer], [Answer1], [Answer2], [Answer3], [Answer4]) VALUES (3, N'DropDown', N'Who was the founder of FBLA?
', N'Hamden L. Forkner
', N'Edward D. Miller
', N'Hamden L. Forkner
', N'Conrad N. Hilton
', N'Jean Buckley
')
INSERT INTO [dbo].[Table] ([Id], [QuestionType], [Question], [CorrectAnswer], [Answer1], [Answer2], [Answer3], [Answer4]) VALUES (4, N'FillBlank', NULL, NULL, NULL, NULL, NULL, NULL)
```
