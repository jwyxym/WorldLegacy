namespace YgomSystem.Network
{
	public enum DeckCode
	{
		NONE = 0,
		ERROR = 1,
		FATAL = 2,
		CRITICAL = 3,
		ERROR_DECK_CONFIG = 1400,
		ERROR_DECK_LIMIT = 1401,
		ERROR_DECK_REGULATION = 1402,
		ERROR_PARAMS_CONFIG = 1403,
		ERROR_TOURNAMENT_STATUS = 1404,
		ERROR_EXHIBITION_STATUS = 1405,
		ERROR_DECK_NAME_LEN = 1406,
		ERROR_DECK_SAME_CARDS = 1407,
		ERROR_DECK_NO = 1408,
		ERROR_CARD_ID = 1409,
		INVALID_DECK_COUNT = 1440,
		INVALID_DECK_NAME = 1441,
		INVALID_DECK_BIKO = 1442,
		CGN_ID_NOT_LINKED = 1443,
		OVER_DECK_LIMIT = 1444,
		INVALID_ACCESS = 1445,
		CDB_SERVER_ERROR = 1446,
		KONAMIID_SERVER_ERROR = 1447,
		NEURON_MAINTENANCE = 1448
	}
}
