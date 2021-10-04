using System.Threading.Tasks;
using Xunit;

namespace Fibonacci.Tests
{

    public class FibonacciUnitTest
    {
        [Fact]
        public async Task Execute44ShouldRetrun701408733() {
            var result = await Compute.ExecuteAsync(new[] {"4"});
            Assert.Equal(3, result[0]);
        }
    }
}