﻿using System;
using System.Text.Json.Serialization;
using FoundFlow.Application.Interfaces;
using FoundFlow.Application.Models;

namespace FoundFlow.Application.Common.Feature.Categories.Delete;

/// <summary>
/// Representa uma solicitação para excluir uma categoria existente.
/// </summary>
public class DeleteCategorieRequest : MediatR.IRequest<Result<DeleteCategorieResponse>>, IAuthorize
{
    /// <summary>
    /// O identificador único (UUID) da categoria a ser excluída.
    /// </summary>
    /// <example>32bf3b72-db19-498c-ad3a-e2d6edde080f</example>
    public Guid Id { get; set; }

    /// <summary>
    /// O identificador único (UUID) do usuário que está solicitando a exclusão. (Ignorado na serialização JSON)
    /// </summary>
    [JsonIgnore]
    public Guid UserId { get; set; }
}