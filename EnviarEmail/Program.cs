using System.Collections.Generic;
using EnviarEmail;

var outlook = new Email("smtp.office365.com", "202003379069@alunos.estacio.br", ENV.PASSWORD);

outlook.SendEmail(
    emailsTo: new List<string>
    {
        "sedinaelson@gmail.com",
        "sedinaelson@live.com",
        "elyoneydegaleno@gmail.com",
        "pedro94932@gmail.com"
    },
    subject: "Enviando Livro",
    body: "Segue em Anexo Livro de Programação",
    attachments: new List<string>
    {
        @"C:\Users\datam\Downloads\Pdf\CAMISA PRETA (1).pdf"
    });
