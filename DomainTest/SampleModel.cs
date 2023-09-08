using Domain.Sample;

namespace DomainTest
{
    public class SampleModel
    {
        [Fact]
        public void コンストラクタ_初期値()
        {
            var target = new Domain.Sample.SampleModel();
            Assert.Equal("Init Value", target.Text.Value.Text);
        }
    }
}