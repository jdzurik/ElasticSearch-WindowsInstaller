using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetElasticsearchSettings
{
  [Serializable]
  public class ElasticSearchSettings
  {
    public String JavaHomeDirectory { get; set; }
    public String ESHomeDirectory { get; set; }

    public String ESMinMemory { get; set; }
    public String ESMaxMemory { get; set; }


  }
}
