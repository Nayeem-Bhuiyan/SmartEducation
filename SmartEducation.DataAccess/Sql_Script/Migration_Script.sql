
CREATE TABLE [__EFMigrationsHistory] (
    [MigrationId] nvarchar(150) NOT NULL,
    [ProductVersion] nvarchar(32) NOT NULL,
    CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
);

CREATE TABLE [ApplicationRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Description] nvarchar(max) NULL,
    [IpAddress] nvarchar(max) NULL,
    [CreatedBy] nvarchar(max) NULL,
    [UpdatedBy] nvarchar(max) NULL,
    [CreatedDate] datetime2 NULL,
    [UpdatedDate] datetime2 NULL,
    [DeletedBy] datetime2 NULL,
    [DeletedDate] datetime2 NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_ApplicationRoles] PRIMARY KEY ([Id])
);

CREATE TABLE [ApplicationUsers] (
    [Id] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Contact] nvarchar(max) NULL,
    [Gender] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NULL,
    [ProfilePicUrl] nvarchar(max) NULL,
    [isActive] bit NULL,
    [LastLoginTime] datetime2 NULL,
    [CreatedBy] nvarchar(max) NULL,
    [UpdatedBy] nvarchar(max) NULL,
    [CreatedDate] datetime2 NULL,
    [UpdatedDate] datetime2 NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_ApplicationUsers] PRIMARY KEY ([Id])
);

CREATE TABLE [Country] (
    [Id] int NOT NULL IDENTITY,
    [countryCode] nvarchar(max) NOT NULL,
    [countryName] nvarchar(max) NOT NULL,
    [shortName] nvarchar(max) NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY ([Id])
);

CREATE TABLE [ApplicationRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_ApplicationRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ApplicationRoleClaims_ApplicationRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [ApplicationRoles] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [ApplicationUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_ApplicationUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ApplicationUserClaims_ApplicationUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUsers] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [ApplicationUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_ApplicationUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_ApplicationUserLogins_ApplicationUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUsers] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [ApplicationUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_ApplicationUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_ApplicationUserRoles_ApplicationRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [ApplicationRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ApplicationUserRoles_ApplicationUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUsers] ([Id]) ON DELETE CASCADE
);

CREATE TABLE [ApplicationUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_ApplicationUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_ApplicationUserTokens_ApplicationUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUsers] ([Id]) ON DELETE CASCADE
);

CREATE INDEX [IX_ApplicationRoleClaims_RoleId] ON [ApplicationRoleClaims] ([RoleId]);

CREATE UNIQUE INDEX [RoleNameIndex] ON [ApplicationRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

CREATE INDEX [IX_ApplicationUserClaims_UserId] ON [ApplicationUserClaims] ([UserId]);

CREATE INDEX [IX_ApplicationUserLogins_UserId] ON [ApplicationUserLogins] ([UserId]);

CREATE INDEX [IX_ApplicationUserRoles_RoleId] ON [ApplicationUserRoles] ([RoleId]);

CREATE INDEX [EmailIndex] ON [ApplicationUsers] ([NormalizedEmail]);

CREATE UNIQUE INDEX [UserNameIndex] ON [ApplicationUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])VALUES (N'20231209065347__Initial_Migration', N'8.0.0');
