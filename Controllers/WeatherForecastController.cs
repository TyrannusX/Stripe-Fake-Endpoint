using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Stripe;

namespace stripe_fake_endpoint.Controllers
{
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        #region Account Endpoints
        [HttpGet]
        [Route("v1/accounts/{accountId}")]
        public IActionResult GetStripeAccount()
        {
            #region Get Account Response
            return Ok(@"{
  'id': 'acct_1032D82eZvKYlo2C',
  'object': 'account',
  'business_profile': {
    'mcc': null,
    'name': 'Stripe.com',
    'product_description': null,
    'support_address': null,
    'support_email': null,
    'support_phone': null,
    'support_url': null,
    'url': null
  },
  'business_type': null,
  'capabilities': {
    'card_payments': 'active',
    'transfers': 'active'
  },
  'charges_enabled': false,
  'country': 'US',
  'created': 1385798567,
  'default_currency': 'usd',
  'details_submitted': false,
  'email': 'site@stripe.com',
  'external_accounts': {
    'object': 'list',
    'data': [],
    'has_more': false,
    'url': '/v1/accounts/acct_1032D82eZvKYlo2C/external_accounts'
  },
  'metadata': {
    'order_id': '6735'
  },
  'payouts_enabled': false,
  'requirements': {
    'current_deadline': null,
    'currently_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'disabled_reason': 'requirements.past_due',
    'errors': [],
    'eventually_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'past_due': [],
    'pending_verification': []
  },
  'settings': {
    'branding': {
      'icon': null,
      'logo': null,
      'primary_color': null,
      'secondary_color': null
    },
    'card_payments': {
      'decline_on': {
        'avs_failure': true,
        'cvc_failure': false
      },
      'statement_descriptor_prefix': null
    },
    'dashboard': {
      'display_name': 'Stripe.com',
      'timezone': 'US/Pacific'
    },
    'payments': {
      'statement_descriptor': '',
      'statement_descriptor_kana': null,
      'statement_descriptor_kanji': null
    },
    'payouts': {
      'debit_negative_balances': true,
      'schedule': {
        'delay_days': 7,
        'interval': 'daily'
      },
      'statement_descriptor': null
    }
  },
  'tos_acceptance': {
    'date': null,
    'ip': null,
    'user_agent': null
  },
  'type': 'standard'
}");
#endregion
        }

        [HttpPost]
        [Route("v1/accounts")]
        public IActionResult PostStripeAccount()
        {
            #region Post Account Response
            return Ok(@"{
  'id': 'acct_1032D82eZvKYlo2C',
  'object': 'account',
  'business_profile': {
    'mcc': null,
    'name': 'Stripe.com',
    'product_description': null,
    'support_address': null,
    'support_email': null,
    'support_phone': null,
    'support_url': null,
    'url': null
  },
  'business_type': null,
  'capabilities': {
    'card_payments': 'active',
    'transfers': 'active'
  },
  'charges_enabled': false,
  'country': 'US',
  'created': 1385798567,
  'default_currency': 'usd',
  'details_submitted': false,
  'email': 'jenny.rosen@example.com',
  'external_accounts': {
    'object': 'list',
    'data': [],
    'has_more': false,
    'url': '/v1/accounts/acct_1032D82eZvKYlo2C/external_accounts'
  },
  'metadata': {},
  'payouts_enabled': false,
  'requirements': {
    'current_deadline': null,
    'currently_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'disabled_reason': 'requirements.past_due',
    'errors': [],
    'eventually_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'past_due': [],
    'pending_verification': []
  },
  'settings': {
    'branding': {
      'icon': null,
      'logo': null,
      'primary_color': null,
      'secondary_color': null
    },
    'card_payments': {
      'decline_on': {
        'avs_failure': true,
        'cvc_failure': false
      },
      'statement_descriptor_prefix': null
    },
    'dashboard': {
      'display_name': 'Stripe.com',
      'timezone': 'US/Pacific'
    },
    'payments': {
      'statement_descriptor': '',
      'statement_descriptor_kana': null,
      'statement_descriptor_kanji': null
    },
    'payouts': {
      'debit_negative_balances': true,
      'schedule': {
        'delay_days': 7,
        'interval': 'daily'
      },
      'statement_descriptor': null
    }
  },
  'tos_acceptance': {
    'date': null,
    'ip': null,
    'user_agent': null
  },
  'type': 'custom',
  'requested_capabilities': [
    'card_payments',
    'transfers'
  ]
}");
            #endregion
        }

        [HttpPost]
        [Route("v1/accounts/{accountId}")]
        public IActionResult UpdateStripeAccount()
        {
            #region Update Account Response
            return Ok(@"{
  'id': 'acct_1032D82eZvKYlo2C',
  'object': 'account',
  'business_profile': {
    'mcc': null,
    'name': 'Stripe.com',
    'product_description': null,
    'support_address': null,
    'support_email': null,
    'support_phone': null,
    'support_url': null,
    'url': null
  },
  'business_type': null,
  'capabilities': {
    'card_payments': 'active',
    'transfers': 'active'
  },
  'charges_enabled': false,
  'country': 'US',
  'created': 1385798567,
  'default_currency': 'usd',
  'details_submitted': false,
  'email': 'jenny.rosen@example.com',
  'external_accounts': {
    'object': 'list',
    'data': [],
    'has_more': false,
    'url': '/v1/accounts/acct_1032D82eZvKYlo2C/external_accounts'
  },
  'metadata': {},
  'payouts_enabled': false,
  'requirements': {
    'current_deadline': null,
    'currently_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'disabled_reason': 'requirements.past_due',
    'errors': [],
    'eventually_due': [
      'business_url',
      'external_account',
      'product_description',
      'support_phone',
      'tos_acceptance.date',
      'tos_acceptance.ip'
    ],
    'past_due': [],
    'pending_verification': []
  },
  'settings': {
    'branding': {
      'icon': null,
      'logo': null,
      'primary_color': null,
      'secondary_color': null
    },
    'card_payments': {
      'decline_on': {
        'avs_failure': true,
        'cvc_failure': false
      },
      'statement_descriptor_prefix': null
    },
    'dashboard': {
      'display_name': 'Stripe.com',
      'timezone': 'US/Pacific'
    },
    'payments': {
      'statement_descriptor': '',
      'statement_descriptor_kana': null,
      'statement_descriptor_kanji': null
    },
    'payouts': {
      'debit_negative_balances': true,
      'schedule': {
        'delay_days': 7,
        'interval': 'daily'
      },
      'statement_descriptor': null
    }
  },
  'tos_acceptance': {
    'date': null,
    'ip': null,
    'user_agent': null
  },
  'type': 'custom',
  'requested_capabilities': [
    'card_payments',
    'transfers'
  ]
}");
            #endregion
        }

        [HttpDelete]
        [Route("v1/accounts/{accountId}")]
        public IActionResult DeleteStripeAccount()
        {
            #region Delete Account Response
            return Ok(@"{
  'id': 'acct_1032D82eZvKYlo2C',
  'object': 'account',
  'deleted': true
}");
            #endregion
        }
        #endregion


        #region Person Endpoints
        [HttpGet]
        [Route("v1/accounts/{accountId}/persons/{personId}")]
        public IActionResult GetSingleStripePerson()
        {
            #region Get Person Response
            return Ok(@"{
  'id': 'person_HL93PEyGKlm09k',
  'object': 'person',
  'account': 'acct_1032D82eZvKYlo2C',
  'created': 1590361088,
  'dob': {
    'day': null,
    'month': null,
    'year': null
  },
  'first_name': null,
  'id_number_provided': false,
  'last_name': null,
  'metadata': {},
  'relationship': {
    'director': false,
    'executive': false,
    'owner': false,
    'percent_ownership': null,
    'representative': false,
    'title': null
  },
  'requirements': {
    'currently_due': [],
    'errors': [],
    'eventually_due': [],
    'past_due': [],
    'pending_verification': []
  },
  'ssn_last_4_provided': false,
  'verification': {
    'additional_document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'details': null,
    'details_code': null,
    'document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'status': 'unverified'
  }
}");
#endregion
        }

        [HttpPost]
        [Route("v1/accounts/{accountId}/persons")]
        public IActionResult PostStripePerson()
        {
            #region Post Person Response
            return Ok(@"{
  'id': 'person_HL93PEyGKlm09k',
  'object': 'person',
  'account': 'acct_1032D82eZvKYlo2C',
  'created': 1590361088,
  'dob': {
    'day': null,
    'month': null,
    'year': null
  },
  'first_name': null,
  'id_number_provided': false,
  'last_name': null,
  'metadata': {},
  'relationship': {
    'director': false,
    'executive': false,
    'owner': false,
    'percent_ownership': null,
    'representative': false,
    'title': null
  },
  'requirements': {
    'currently_due': [],
    'errors': [],
    'eventually_due': [],
    'past_due': [],
    'pending_verification': []
  },
  'ssn_last_4_provided': false,
  'verification': {
    'additional_document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'details': null,
    'details_code': null,
    'document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'status': 'unverified'
  }
}
");
            #endregion
        }

        [HttpPost]
        [Route("v1/accounts/{accountId}/persons/{personId}")]
        public IActionResult UpdateStripePerson()
        {
            #region Update Person Response
            return Ok(@"{
  'id': 'person_HL93PEyGKlm09k',
  'object': 'person',
  'account': 'acct_1032D82eZvKYlo2C',
  'created': 1590361088,
  'dob': {
    'day': null,
    'month': null,
    'year': null
  },
  'first_name': null,
  'id_number_provided': false,
  'last_name': null,
  'metadata': {
    'order_id': '6735'
  },
  'relationship': {
    'director': false,
    'executive': false,
    'owner': false,
    'percent_ownership': null,
    'representative': false,
    'title': null
  },
  'requirements': {
    'currently_due': [],
    'errors': [],
    'eventually_due': [],
    'past_due': [],
    'pending_verification': []
  },
  'ssn_last_4_provided': false,
  'verification': {
    'additional_document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'details': null,
    'details_code': null,
    'document': {
      'back': null,
      'details': null,
      'details_code': null,
      'front': null
    },
    'status': 'unverified'
  }");
            #endregion
        }

        [HttpGet]
        [Route("v1/accounts/{accountId}/persons")]
        public IActionResult ListAllStripePersons()
        {
            #region List Persons Response
            return Ok(@"{
  'object': 'list',
  'url': '/v1/accounts/acct_1032D82eZvKYlo2C/persons',
  'has_more': false,
  'data': []
}");
            #endregion
        }
        #endregion

        #region File Endpoints
        [HttpPost]
        [Route("v1/files")]
        public IActionResult PostStripeFile()
        {
            #region Post Stripe File Response
            return Ok(@"{
  'id': 'file_1FvSUR2eZvKYlo2C8zHSKeSA',
  'object': 'file',
  'created': 1577728635,
  'filename': 'blob',
  'links': {
    'object': 'list',
    'data': [
      {
        'id': 'link_1GmSlY2eZvKYlo2Cea7oWGBn',
        'object': 'file_link',
        'created': 1590361080,
        'expired': false,
        'expires_at': null,
        'file': 'file_1FvSUR2eZvKYlo2C8zHSKeSA',
        'livemode': false,
        'metadata': {},
        'url': 'https://files.stripe.com/links/fl_test_aGYOzSn7MYhdekW6y2KM8EU7'
      }
    ],
    'has_more': true,
    'url': '/v1/file_links?file=file_1FvSUR2eZvKYlo2C8zHSKeSA'
  },
  'purpose': 'dispute_evidence',
  'size': 64970,
  'title': null,
  'type': 'jpg',
  'url': 'https://files.stripe.com/v1/files/file_1FvSUR2eZvKYlo2C8zHSKeSA/contents',
  'file': '{a file descriptor}'
}");
            #endregion
        }
        #endregion

        #region Token Endpoints
        [HttpPost]
        [Route("v1/tokens")]
        public IActionResult PostStripeToken()
        {
            #region Post Person Token Response
            return Ok(@"{
  'id': 'cpt_1EDww82eZvKYlo2CsdelTHFu',
  'object': 'token',
  'client_ip': '8.21.168.117',
  'created': 1552582904,
  'livemode': false,
  'type': 'person',
  'used': false
}")
            #endregion
        }
        #endregion
    }
}
