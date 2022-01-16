# Tabela PessoaDados

CREATE TABLE [dbo].[PessoaDados](
	[IdDados] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[DataNascimento] [date] NOT NULL,
 CONSTRAINT [PK_PessoaDados] PRIMARY KEY CLUSTERED 
(
	[IdDados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

# Tabela PessoaTelefone

CREATE TABLE [dbo].[PessoaTelefone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TelefonePessoal] [int] NOT NULL,
	[TelefoneResidencial] [int] NOT NULL,
	[TelefoneRecado] [int] NOT NULL,
 CONSTRAINT [PK_PessoaTelefone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]