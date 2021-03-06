// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/euromilhoes.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server {
  public static partial class Euromilhoes
  {
    static readonly string __ServiceName = "Euromilhoes";

    static readonly grpc::Marshaller<global::Server.PedidoAposta> __Marshaller_PedidoAposta = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoAposta.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.ResultadoPedido> __Marshaller_ResultadoPedido = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ResultadoPedido.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.PedidoListarApostas> __Marshaller_PedidoListarApostas = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoListarApostas.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.ListaDeApostas> __Marshaller_ListaDeApostas = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ListaDeApostas.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.PedidoListarUtilizadores> __Marshaller_PedidoListarUtilizadores = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoListarUtilizadores.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.ListaUtilizadores> __Marshaller_ListaUtilizadores = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ListaUtilizadores.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.PedidoArquivarApostas> __Marshaller_PedidoArquivarApostas = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoArquivarApostas.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.PedidoSubmeterChaveVencedora> __Marshaller_PedidoSubmeterChaveVencedora = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoSubmeterChaveVencedora.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.PedidoListarApostasVencedoras> __Marshaller_PedidoListarApostasVencedoras = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.PedidoListarApostasVencedoras.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.ResultadoListarApostasVencedoras> __Marshaller_ResultadoListarApostasVencedoras = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.ResultadoListarApostasVencedoras.Parser.ParseFrom);

    static readonly grpc::Method<global::Server.PedidoAposta, global::Server.ResultadoPedido> __Method_RegistarAposta = new grpc::Method<global::Server.PedidoAposta, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RegistarAposta",
        __Marshaller_PedidoAposta,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoListarApostas, global::Server.ListaDeApostas> __Method_ListarApostas = new grpc::Method<global::Server.PedidoListarApostas, global::Server.ListaDeApostas>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarApostas",
        __Marshaller_PedidoListarApostas,
        __Marshaller_ListaDeApostas);

    static readonly grpc::Method<global::Server.PedidoListarUtilizadores, global::Server.ListaUtilizadores> __Method_ListarUtilizadores = new grpc::Method<global::Server.PedidoListarUtilizadores, global::Server.ListaUtilizadores>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarUtilizadores",
        __Marshaller_PedidoListarUtilizadores,
        __Marshaller_ListaUtilizadores);

    static readonly grpc::Method<global::Server.PedidoArquivarApostas, global::Server.ResultadoPedido> __Method_ArquivarApostas = new grpc::Method<global::Server.PedidoArquivarApostas, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ArquivarApostas",
        __Marshaller_PedidoArquivarApostas,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoSubmeterChaveVencedora, global::Server.ResultadoPedido> __Method_SubmeterChaveVencedora = new grpc::Method<global::Server.PedidoSubmeterChaveVencedora, global::Server.ResultadoPedido>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SubmeterChaveVencedora",
        __Marshaller_PedidoSubmeterChaveVencedora,
        __Marshaller_ResultadoPedido);

    static readonly grpc::Method<global::Server.PedidoListarApostasVencedoras, global::Server.ResultadoListarApostasVencedoras> __Method_ListarApostasVencedoras = new grpc::Method<global::Server.PedidoListarApostasVencedoras, global::Server.ResultadoListarApostasVencedoras>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListarApostasVencedoras",
        __Marshaller_PedidoListarApostasVencedoras,
        __Marshaller_ResultadoListarApostasVencedoras);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server.EuromilhoesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Euromilhoes</summary>
    [grpc::BindServiceMethod(typeof(Euromilhoes), "BindService")]
    public abstract partial class EuromilhoesBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Server.ResultadoPedido> RegistarAposta(global::Server.PedidoAposta request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Server.ListaDeApostas> ListarApostas(global::Server.PedidoListarApostas request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Server.ListaUtilizadores> ListarUtilizadores(global::Server.PedidoListarUtilizadores request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Server.ResultadoPedido> ArquivarApostas(global::Server.PedidoArquivarApostas request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Server.ResultadoPedido> SubmeterChaveVencedora(global::Server.PedidoSubmeterChaveVencedora request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Server.ResultadoListarApostasVencedoras> ListarApostasVencedoras(global::Server.PedidoListarApostasVencedoras request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EuromilhoesBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RegistarAposta, serviceImpl.RegistarAposta)
          .AddMethod(__Method_ListarApostas, serviceImpl.ListarApostas)
          .AddMethod(__Method_ListarUtilizadores, serviceImpl.ListarUtilizadores)
          .AddMethod(__Method_ArquivarApostas, serviceImpl.ArquivarApostas)
          .AddMethod(__Method_SubmeterChaveVencedora, serviceImpl.SubmeterChaveVencedora)
          .AddMethod(__Method_ListarApostasVencedoras, serviceImpl.ListarApostasVencedoras).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EuromilhoesBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_RegistarAposta, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoAposta, global::Server.ResultadoPedido>(serviceImpl.RegistarAposta));
      serviceBinder.AddMethod(__Method_ListarApostas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoListarApostas, global::Server.ListaDeApostas>(serviceImpl.ListarApostas));
      serviceBinder.AddMethod(__Method_ListarUtilizadores, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoListarUtilizadores, global::Server.ListaUtilizadores>(serviceImpl.ListarUtilizadores));
      serviceBinder.AddMethod(__Method_ArquivarApostas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoArquivarApostas, global::Server.ResultadoPedido>(serviceImpl.ArquivarApostas));
      serviceBinder.AddMethod(__Method_SubmeterChaveVencedora, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoSubmeterChaveVencedora, global::Server.ResultadoPedido>(serviceImpl.SubmeterChaveVencedora));
      serviceBinder.AddMethod(__Method_ListarApostasVencedoras, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Server.PedidoListarApostasVencedoras, global::Server.ResultadoListarApostasVencedoras>(serviceImpl.ListarApostasVencedoras));
    }

  }
}
#endregion
