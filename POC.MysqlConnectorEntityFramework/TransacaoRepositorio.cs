
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.MysqlConnectorEntityFramework
{
	public class TransacaoRepositorio
	{
		protected readonly Context _context;

		public TransacaoRepositorio(Context context)
		{
			_context = context;
		}

		public void Dispose()
		{
			_context.Dispose();
		}

		public async Task Add(Transacao entity)
		{
			try
			{
				await _context.Transacao.AddAsync(entity);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new System.ArgumentException("Falha ao inserir transação: " + ex.Message);
			}
		}
		public async Task Update(Transacao entity)
		{
			try
			{
				_context.Transacao.Update(entity);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw new System.ArgumentException("Falha ao atualizar transação: " + ex.Message);
			}
		}
		public async Task Delete(Transacao entity)
		{
			try
			{
				_context.Transacao.Remove(entity);
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				//Log.Erro(ex);
				throw new ArgumentException("Falha ao excluir transação: " + ex.Message);
			}
		}
		public Task<IEnumerable<Transacao>> ListByNumeroSequencialTransacaoTEF(int numeroSequencialTransacaoTEF)
		{
			var transacoes = _context.Transacao.Where(x => x.Bit11NumeroSequencialTransacaoTef.Equals(numeroSequencialTransacaoTEF)).AsEnumerable();
			return Task.FromResult<IEnumerable<Transacao>>(transacoes);
		}

		public async Task<Transacao> GetByBit11AndBit37(int bit11, int bit37)
		{
			var transacoes = _context.Transacao.Where(x => x.Bit11NumeroSequencialTransacaoTef == bit11 && x.Bit37NSUIntegradora == bit37).FirstOrDefault();
			return transacoes;
		}

		public async Task<Transacao> GetByBit11AndType(int bit11, int type)
		{
			var transacoes = _context.Transacao.Where(x => x.Bit11NumeroSequencialTransacaoTef == bit11 && x.TipoTransacao == type).FirstOrDefault();
			return transacoes;
		}

		public async Task<Transacao> GetByBit11Bit37AndType(int bit11, int bit37, int type)
		{
			var transacoes = _context.Transacao.Where(x => x.Bit11NumeroSequencialTransacaoTef == bit11
			 && x.Bit37NSUIntegradora == bit37
			 && x.TipoTransacao == type).FirstOrDefault();
			return transacoes;
		}

		public async Task<IEnumerable<Transacao>> GetByBit11andType(int bit11, int debitoCredito)
		{
			var transacoes = _context.Transacao.Where(x => x.Bit11NumeroSequencialTransacaoTef == bit11 &&
			x.DebitoCredito == debitoCredito).AsEnumerable();
			return transacoes;
		}



		public async Task<Transacao> GetById(Guid idTransacao)
		{
			try
			{
				var transacao = await _context.Transacao.Where(x => x.IdTransacao.Equals(idTransacao)).FirstOrDefaultAsync();
				return transacao;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public async Task<IList<Transacao>> GetByFirstParcel(byte[] idTransacao)
		{
			try
			{
				var transacao = _context.Transacao.Where(x => x.IdPrimeiraParcela.Equals(idTransacao)).OrderBy(x => x.ParcelaAtual).ToList();
				return transacao;
			}
			catch (Exception ex)
			{
				return null;
			}
		}
		public Task<IEnumerable<Transacao>> ListByNaoConciliados()
		{
			var transacoes = _context.Transacao.Where(x => x.DtConciliacao == null).AsEnumerable();
			return Task.FromResult<IEnumerable<Transacao>>(transacoes);
		}
	}
}
