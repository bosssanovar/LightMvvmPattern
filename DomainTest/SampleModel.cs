using Domain.Sample;

namespace DomainTest
{
    public class SampleModel
    {
        [Fact]
        public void �R���X�g���N�^_�����l()
        {
            var target = new Domain.Sample.SampleModel();
            Assert.Equal("Init Value", target.Text.Value.Text);
        }
    }
}