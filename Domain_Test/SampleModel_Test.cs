using Domain.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain_Test
{
    public class SampleModel_Test
    {

        [Fact]
        public void コンストラクタ_初期値() 
        {
            var target = new SampleModel();
            Assert.Equal("InitValue", target.Text.Value.Text);
        }
    }
}
