CREATE PROCEDURE BuscaCurso
    @NomeCurso VARCHAR(20)
AS
SET @NomeCurso = '%'+@NomeCurso+'%';

SELECT c.id_curso, c.nome_curso, a.nome, isnull(a.sexo, 'NI') sexo
    FROM Cursos C
        INNER JOIN Turmas t on (t.id_turma == c.id_curso)
        INNER JOIN AlunosXTurmas alt on (alt.id_turma == t.id_turma)
        INNER JOIN Alunos a on (a.id_aluno == alt.id_curso)
    WHERE nome_curso like @NomeCurso


exec BuscaCurso 'Powerpoint';
exec BuscaCurso 'Excel';
exec BuscaCurso '%'; // % é tudo

---------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE IncluirNovoCurso
    @NomeCurso VARCHAR(100)
    @LoginCadastro VARCHAR(100)
AS
BEGIN
    DECLARE @vIdCurso INT;

    SELECT @vIdCurso = max(id_curso) + 1 from cursos;

    INSERT INTO cursos (id_curso, nome_curso, data_cadastro, login_cadastro)
        VALUES (@vIdCurso, @NomeCurso, getdate(), @LoginCadastro);
    
    SELECT @vIdCurso = id_curso FROM cursos WHERE id_curso = @vIdCurso;
    
    SELECT @vIdCurso as retorno;
END
GO

EXEC IncluirNovoCurso 'VBA I', 'ATROVATO';
SELECT * FROM cursos order by id_curso desc;
DELETE FROM cursos WHERE id_curso in (11, 12);

---------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE IncluirNovoCursoComValidacao
    @NomeCurso VARCHAR(100)
    @LoginCadastro VARCHAR(100)
AS
BEGIN
    DECLARE @vIdCurso int;
    DECLARE @vExisteCurso int;

    SELECT @vExisteCurso = id_curso from cursos WHERE nome_curso= @NomeCurso;

    IF @vExisteCurso > 0
        BEGIN
            SELECT 'O curso já Existe!' as retorno
        END
    ELSE
        BEGIN
            SELECT @vIdCurso = max(id_curso) + 1 from cursos;

            INSERT INTO cursos (id_curso, nome_curso, data_cadastro, login_cadastro)
                VALUES (@vIdCurso, @NomeCurso, getdate(), @LoginCadastro);
            
            SELECT @vIdCurso = id_curso FROM cursos WHERE id_curso = @vIdCurso;
    
            SELECT @vIdCurso as retorno;
        END
END
GO

EXEC IncluirNovoCursoComValidacao 'VBA II', 'ALEX ATROVATO';
SELECT * FROM cursos order by id_curso desc;
DELETE FROM cursos WHERE id_curso in (11, 12);

---------------------------------------------------------------------------------------------------------------------


DROP PROCEDURE IF EXISTS BuscaCurso, IncluirNovoCurso, IncluirNovoCursoComValidacao;
GO