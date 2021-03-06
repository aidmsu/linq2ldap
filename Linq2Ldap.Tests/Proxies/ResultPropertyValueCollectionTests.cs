using Xunit;
using System;
using Linq2Ldap.Tests.Proxies;
using System.DirectoryServices;

namespace Linq2Ldap.Tests.Proxies {
    public class ResultAttributeValueListTests {
        [Fact]
        public void Constructor_ThrowsOnNull() {
            Assert.Throws<ArgumentNullException>(() => new Linq2Ldap.Core.Proxies.AttributeValueList((ResultPropertyValueCollection)null));
        }
    }
}