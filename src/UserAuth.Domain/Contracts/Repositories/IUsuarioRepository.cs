﻿using UserAuth.Domain.Entities;

namespace UserAuth.Domain.Contracts.Repositories;

public interface IUsuarioRepository : IRepository<Usuario>
{
    void Cadastrar(Usuario usuario);
    void Atualizar(Usuario usuario);
    Task<Usuario?> ObterPorId(int id);
    Task<Usuario?> ObterPorEmail(string email);
    Task<List<Usuario>> ObterTodos();
    Task<Usuario?> ObterPorTokenDeVerificacao(string token);
    Task<Usuario?> ObterPorTokenDeResetSenha(string token);
    Task<Usuario?> ObterPedidoResetSenhaValido(int usuarioId);
}