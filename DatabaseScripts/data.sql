INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cb56dcb6-c3be-463a-8129-8d3dfcfd2afa', N'admin_user', N'admin_user', N'cdbf8bb8-0633-4bea-ac19-33b59f6764f8')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f2ed90b6-c59c-404d-a2f3-6d1ae70fa850', N'publisher_user', N'publisher_user', N'b1768828-4d41-4506-beed-50e94aeff622')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'41a20e88-8382-406a-bf38-243965b66b5e', N'adam@nature.com', N'ADAM@NATURE.COM', N'adam@nature.com', N'ADAM@NATURE.COM', 1, N'AQAAAAEAACcQAAAAEH/Merz7+nZ/vWJwSxuYhczLS5pGrycvW6/S6qH0gqRsEBwQK5oGQx+E1pBXVYdQlg==', N'GH7UOF3DGFA43JT77F7QRNCIEGRQNFOS', N'765ff255-5c25-48f2-83f7-b0db70819e54', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4958f6ac-27ed-4ec9-96cf-6ede8e3fa6a8', N'admin@nature.com', N'ADMIN@NATURE.COM', N'admin@nature.com', N'ADMIN@NATURE.COM', 1, N'AQAAAAEAACcQAAAAEColhap+jmt7Ds09Jqv3ksXDnW9cY68B1yUebz790RxVpvjc20gDlQ+FHi8ho1iEEQ==', N'ORX4J4JYNAFCZ2Y7PYDBEG4VEVI63RD5', N'e96bd260-0a6e-4a00-9fb3-23b38dd64cfe', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e6fa947e-3604-4286-90e9-12f537f55569', N'gary@nature.com', N'GARY@NATURE.COM', N'gary@nature.com', N'GARY@NATURE.COM', 1, N'AQAAAAEAACcQAAAAEFjUXKBnEDkl43cqm5C/VMOEmU/F7dXk1lMdv/ozybxEmezdJUNN98jpRy/4rSTQgA==', N'NUWZI5AIXYHDAWTKYC46WDXI5GGKNEE3', N'757aeec2-64e7-440c-b1af-cbdec3c4d9aa', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4958f6ac-27ed-4ec9-96cf-6ede8e3fa6a8', N'cb56dcb6-c3be-463a-8129-8d3dfcfd2afa')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'41a20e88-8382-406a-bf38-243965b66b5e', N'f2ed90b6-c59c-404d-a2f3-6d1ae70fa850')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e6fa947e-3604-4286-90e9-12f537f55569', N'f2ed90b6-c59c-404d-a2f3-6d1ae70fa850')
SET IDENTITY_INSERT [dbo].[Image] ON
INSERT INTO [dbo].[Image] ([Id], [Heading], [Description], [ImageUrl]) VALUES (2, N'Forest ', N'Forest and a gentle water stream', N'Wild life.jpg')
INSERT INTO [dbo].[Image] ([Id], [Heading], [Description], [ImageUrl]) VALUES (3, N'Summer Flowers', N'Enchanting Sunflowers facing morning sunshine', N'Sunflower.jpg')
INSERT INTO [dbo].[Image] ([Id], [Heading], [Description], [ImageUrl]) VALUES (4, N'Nature Park', N'A park  closely tied with nature', N'Nature_Park.jpg')
SET IDENTITY_INSERT [dbo].[Image] OFF
SET IDENTITY_INSERT [dbo].[Publisher] ON
INSERT INTO [dbo].[Publisher] ([Id], [EmailAddresss], [PublisherName]) VALUES (1, N'gary@nature.com', N'Gary Smith')
INSERT INTO [dbo].[Publisher] ([Id], [EmailAddresss], [PublisherName]) VALUES (2, N'adam@nature.com', N'Adam Bell')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
SET IDENTITY_INSERT [dbo].[UploadRecord] ON
INSERT INTO [dbo].[UploadRecord] ([Id], [ImageId], [PublisherId], [UploadTime]) VALUES (2, 2, 1, N'2020-12-03 12:07:13')
INSERT INTO [dbo].[UploadRecord] ([Id], [ImageId], [PublisherId], [UploadTime]) VALUES (3, 3, 1, N'2020-12-03 12:08:42')
INSERT INTO [dbo].[UploadRecord] ([Id], [ImageId], [PublisherId], [UploadTime]) VALUES (4, 4, 2, N'2020-12-03 12:12:59')
SET IDENTITY_INSERT [dbo].[UploadRecord] OFF
