#if (!ENTERPRISE_EDITION)
#warning This class should be used in Enterprise Edition.
#endif

namespace Ex03
{
    class EnterpriseUtility{

    }
}

#define STANDARD_EDITION
#define ENTERPRISE_EDITION

#if (STANDARD_EDITION && ENTERPRISE_EDITION)
#error USe a either STANDARD or ENTERPRISE edition.
#endif

namespace Ex03
{
    class Program{
        
    }
}