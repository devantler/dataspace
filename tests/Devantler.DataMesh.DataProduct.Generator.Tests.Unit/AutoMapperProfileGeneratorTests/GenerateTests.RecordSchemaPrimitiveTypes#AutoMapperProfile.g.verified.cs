﻿//HintName: AutoMapperProfile.g.cs
// <auto-generated>
// This code was generated by: 'Devantler.DataMesh.DataProduct.Generator.IncrementalGenerators.AutoMapperProfileGenerator'.
// Any changes made to this file will be overwritten.
using AutoMapper;
using Devantler.DataMesh.DataProduct.Models;
using Devantler.DataMesh.DataProduct.DataStore.Relational;
namespace Devantler.DataMesh.DataProduct;
/// <summary>
/// AutoMapper profile for mapping between models and entities.
/// </summary>
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        _ = CreateMap<RecordSchemaPrimitiveTypes, RecordSchemaPrimitiveTypesEntity>().ReverseMap();
    }
}