using System.Web.Http;
using System.Web.Routing;
using Trie.Services;

namespace Trie.Controllers
{
    [RoutePrefix("api/trie")]
    public class TrieController : ApiController
    {
  

        /// <summary>
        /// Procurar uma palavra na árvore
        /// </summary>       
        [Route("")]
        [HttpGet]
        public IHttpActionResult Get(string keyWord)
        {
            var result = TrieService.search(keyWord);
            return Ok(result);
        }

        /// <summary>
        ///  Incluir uma nova palavara no árvore
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPost]
        public IHttpActionResult Post([FromBody]string keyword)
        {
            TrieService.insert(keyword);
            return Created<string>("",keyword);
        }

        /// <summary>
        /// Verifica se na árvore existe uma palavra com prefixo indicado
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        [Route("starts-with")]
        [HttpGet]
        public IHttpActionResult StartWith(string keyWord)
        {
            var result = TrieService.startsWith(keyWord);
            return Ok(result);
        }


    }
}
