﻿using RiotSharp.ChampionEndpoint;
using RiotSharp.CurrentGameEndpoint;
using RiotSharp.FeaturedGamesEndpoint;
using RiotSharp.GameEndpoint;
using RiotSharp.LeagueEndpoint;
using RiotSharp.MatchEndpoint;
using RiotSharp.SummonerEndpoint;
using RiotSharp.ChampionMasteryEndpoint;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using RiotSharp.MatchListEndpoint;
using RiotSharp.Misc;

namespace RiotSharp.Interfaces
{
    /// <summary>
    /// Entry point for the API.
    /// </summary>
    public interface IRiotApi
    {
        #region Summoner-V3
        /// <summary>
        /// Get a summoner by summoner id synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="summonerId">Id of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Summoner GetSummonerBySummonerId(Region region, long summonerId);

        /// <summary>
        /// Get a summoner by summoner id asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="summonerId">Id of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Task<Summoner> GetSummonerBySummonerIdAsync(Region region, long summonerId);

        /// <summary>
        /// Get a summoner by account id asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="accountId">Account id of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Task<Summoner> GetSummonerByAccountIdAsync(Region region, long accountId);

        /// <summary>
        /// Get a summoner by account id synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="accountId">Account id of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Summoner GetSummonerByAccountId(Region region, long accountId);

        /// <summary>
        /// Get a summoner by name synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="summonerName">Name of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Summoner GetSummonerByName(Region region, string summonerName);

        /// <summary>
        /// Get a summoner by name asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a summoner.</param>
        /// <param name="summonerName">Name of the summoner you're looking for.</param>
        /// <returns>A summoner.</returns>
        Task<Summoner> GetSummonerByNameAsync(Region region, string summonerName);
        #endregion

        /// <summary>
        /// Get the list of champions by region synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for champions.</param>
        /// <param name="freeToPlay">If set to true will return only free to play champions.</param>
        /// <returns>A list of champions.</returns>
        List<Champion> GetChampions(Region region, bool freeToPlay = false);

        /// <summary>
        /// Get the list of champions by region asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for champions.</param>
        /// <param name="freeToPlay">If set to true will return only free to play champions.</param>
        /// <returns>A list of champions.</returns>
        Task<List<Champion>> GetChampionsAsync(Region region, bool freeToPlay = false);

        /// <summary>
        /// Get a champion from its id synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a champion.</param>
        /// <param name="championId">Id of the champion you're looking for.</param>
        /// <returns>A champion.</returns>
        Champion GetChampion(Region region, int championId);

        /// <summary>
        /// Get a champion from its id asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a champion.</param>
        /// <param name="championId">Id of the champion you're looking for.</param>
        /// <returns>A champion.</returns>
        Task<Champion> GetChampionAsync(Region region, int championId);

        /// <summary>
        /// Get mastery pages for a summoner id synchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for mastery pages for a list of summoners.</param>
        /// <param name="summonerId">A summoner id for which you wish to retrieve the masteries.</param>
        /// <returns>A list of mastery pages for the summoner.</returns>
        List<MasteryPage> GetMasteryPages(Region region, long summonerId);

        /// <summary>
        /// Get mastery pages for a summoner id asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for mastery pages for a list of summoners.</param>
        /// <param name="summonerId">A summoner id for which you wish to retrieve the masteries.</param>
        /// <returns>A list of mastery pages for the summoner.</returns>
        Task<List<MasteryPage>> GetMasteryPagesAsync(Region region, long summonerId);

        /// <summary>
        /// Get rune pages for a list of summoner ids synchronously, you can submit more than 40 summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for mastery pages for a list of summoners.</param>
        /// <param name="summonerIds">A list of summoner ids for which you wish to retrieve the masteries, not limited
        /// to 40.</param>
        /// <returns>A dictionary where the keys are the summoners' ids and the values are lists of rune pages.
        /// </returns>
        Dictionary<long, List<RunePage>> GetRunePages(Region region, List<long> summonerIds);

        /// <summary>
        /// Get rune pages for a list of summoner ids asynchronously, you can submit more than 40 summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for mastery pages for a list of summoners.</param>
        /// <param name="summonerIds">A list of summoner ids for which you wish to retrieve the masteries, not limited
        /// to 40.</param>
        /// <returns>A dictionary where the keys are the summoners' ids and the values are lists of rune pages.
        /// </returns>
        Task<Dictionary<long, List<RunePage>>> GetRunePagesAsync(Region region, List<long> summonerIds);

        /// <summary>
        /// Retrieves the league entries for the specified summoners, you can submit more than 10 summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for the leagues of summoners.</param>
        /// <param name="summonerIds">The summoner ids, not limited to 10.</param>
        /// <returns>A map of list of league entries indexed by the summoner id.</returns>
        Dictionary<long, List<League>> GetLeagues(Region region, List<long> summonerIds);

        /// <summary>
        /// Retrieves the league entries for the specified summoners asynchronously, you can submit more than 10
        /// summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for the leagues of summoners.</param>
        /// <param name="summonerIds">The summoner ids, not limited to 10.</param>
        /// <returns>A map of list of league entries indexed by the summoner id.</returns>
        Task<Dictionary<long, List<League>>> GetLeaguesAsync(Region region, List<long> summonerIds);

        /// <summary>
        /// Retrieves the entire leagues for the specified summoners, you can submit more than 10 summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for the leagues of summoners.</param>
        /// <param name="summonerIds">The summoner ids, not limited to 10.</param>
        /// <returns>A map of list of leagues indexed by the summoner id.</returns>
        Dictionary<long, List<League>> GetEntireLeagues(Region region, List<long> summonerIds);

        /// <summary>
        /// Retrieves the entire leagues for the specified summoners asynchronously, you can submit more than 10
        /// summoner ids.
        /// </summary>
        /// <param name="region">Region in which you wish to look for the leagues of summoners.</param>
        /// <param name="summonerIds">The summoner ids, not limited to 10.</param>
        /// <returns>A map of list of leagues indexed by the summoner id.</returns>
        Task<Dictionary<long, List<League>>> GetEntireLeaguesAsync(Region region, List<long> summonerIds);

        /// <summary>
        /// Get the challenger league for a particular queue.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a challenger league.</param>
        /// <param name="queue">Queue in which you wish to look for a challenger league.</param>
        /// <returns>A league which contains all the challengers for this specific region and queue.</returns>
        League GetChallengerLeague(Region region, string queue);

        /// <summary>
        /// Get the challenger league for a particular queue asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a challenger league.</param>
        /// <param name="queue">Queue in which you wish to look for a challenger league.</param>
        /// <returns>A league which contains all the challengers for this specific region and queue.</returns>
        Task<League> GetChallengerLeagueAsync(Region region, string queue);

        /// <summary>
        /// Get the master league for a particular queue.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a master league.</param>
        /// <param name="queue">Queue in which you wish to look for a master league.</param>
        /// <returns>A league which contains all the masters for this specific region and queue.</returns>
        League GetMasterLeague(Region region, string queue);

        /// <summary>
        /// Get the master league for a particular queue asynchronously.
        /// </summary>
        /// <param name="region">Region in which you wish to look for a master league.</param>
        /// <param name="queue">Queue in which you wish to look for a master league.</param>
        /// <returns>A league which contains all the masters for this specific region and queue.</returns>
        Task<League> GetMasterLeagueAsync(Region region, string queue);

        /// <summary>
        /// Get match information about a specific match synchronously.
        /// </summary>
        /// <param name="region">Region in which the match took place.</param>
        /// <param name="matchId">The match ID to be retrieved.</param>
        /// <param name="includeTimeline">Whether or not to include timeline information.</param>
        /// <returns>A match detail object containing information about the match.</returns>
        MatchDetail GetMatch(Region region, long matchId, bool includeTimeline = false);

        /// <summary>
        /// Get match information about a specific match asynchronously.
        /// </summary>
        /// <param name="region">Region in which the match took place.</param>
        /// <param name="matchId">The match ID to be retrieved.</param>
        /// <param name="includeTimeline">Whether or not to include timeline information.</param>
        /// <returns>A match detail object containing information about the match.</returns>
        Task<MatchDetail> GetMatchAsync(Region region, long matchId, bool includeTimeline = false);

        /// <summary>
        /// Get the list of matches of a specific summoner synchronously.
        /// </summary>
        /// <param name="region">Region in which the summoner is.</param>
        /// <param name="summonerId">Summoner ID for which you want to retrieve the match list.</param>
        /// <param name="championIds">List of champion IDS to use for fetching games.</param>
        /// <param name="rankedQueues">List of ranked queue types to use for fetching games. Non-ranked queue types
        ///  will be ignored.</param>
        /// <param name="seasons">List of seasons for which to filter the match list by.</param>
        /// <param name="beginTime">The earliest date you wish to get matches from.</param>
        /// <param name="endTime">The latest date you wish to get matches from.</param>
        /// <param name="beginIndex">The begin index to use for fetching matches.</param>
        /// <param name="endIndex">The end index to use for fetching matches.</param>
        /// <returns>A list of Match references object.</returns>
        MatchList GetMatchList(Region region, long summonerId, List<long> championIds = null, List<string> rankedQueues = null,
            List<MatchEndpoint.Enums.Season> seasons = null, DateTime? beginTime = null, DateTime? endTime = null,
            int? beginIndex = null, int? endIndex = null);

        /// <summary>
        /// Get the list of matches of a specific summoner asynchronously.
        /// </summary>
        /// <param name="region">Region in which the summoner is.</param>
        /// <param name="summonerId">Summoner ID for which you want to retrieve the match list.</param>
        /// <param name="championIds">List of champion IDS to use for fetching games.</param>
        /// <param name="rankedQueues">List of ranked queue types to use for fetching games. Non-ranked queue types
        ///  will be ignored.</param>
        /// <param name="seasons">List of seasons for which to filter the match list by.</param>
        /// <param name="beginTime">The earliest date you wish to get matches from.</param>
        /// <param name="endTime">The latest date you wish to get matches from.</param>
        /// <param name="beginIndex">The begin index to use for fetching matches.</param>
        /// <param name="endIndex">The end index to use for fetching matches.</param>
        /// <returns>A list of Match references object.</returns>
        Task<MatchList> GetMatchListAsync(Region region, long summonerId, List<long> championIds = null,
            List<string> rankedQueues = null, List<MatchEndpoint.Enums.Season> seasons = null, DateTime? beginTime = null,
            DateTime? endTime = null, int? beginIndex = null, int? endIndex = null);

        /// <summary>
        /// Get the 10 most recent games by summoner ID synchronously.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <returns>A list of the 10 most recent games.</returns>
        List<Game> GetRecentGames(Region region, long summonerId);

        /// <summary>
        /// Get the 10 most recent games by summoner ID asynchronously.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve recent games.</param>
        /// <returns>A list of the 10 most recent games.</returns>
        Task<List<Game>> GetRecentGamesAsync(Region region, long summonerId);

        /// <summary>
        /// Gets the current game by summoner ID synchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve current game.</param>
        /// <returns>Current game of the summoner.</returns>
        CurrentGame GetCurrentGame(Platform platform, long summonerId);

        /// <summary>
        /// Gets the current game by summoner ID asynchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve current game.</param>
        /// <returns>Current game of the summoner.</returns>
        Task<CurrentGame> GetCurrentGameAsync(Platform platform, long summonerId);

        /// <summary>
        /// Gets the featured games by region synchronously.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>Featured games for the region.</returns>
        FeaturedGames GetFeaturedGames(Region region);

        /// <summary>
        /// Gets the featured games by region asynchronously.
        /// </summary>
        /// <param name="region">Region where to retrieve the data.</param>
        /// <returns>Featured games for the region.</returns>
        Task<FeaturedGames> GetFeaturedGamesAsync(Region region);

        /// <summary>
        /// Gets a champion mastery by summoner ID synchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <param name="championId">ID of the champion for which to retrieve mastery.</param>
        /// <returns>Champion mastery for summoner ID and champion ID.</returns>
        ChampionMastery GetChampionMastery(Platform platform, long summonerId, int championId);

        /// <summary>
        /// Gets a champion mastery by summoner ID asynchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <param name="championId">ID of the champion for which to retrieve mastery.</param>
        /// <returns>Champion mastery for summoner ID and champion ID.</returns>
        Task<ChampionMastery> GetChampionMasteryAsync(Platform platform, long summonerId, int championId);

        /// <summary>
        /// Gets all champions mastery by summoner ID synchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <returns>All champions mastery entries for the specified summoner ID.</returns>
        List<ChampionMastery> GetChampionMasteries(Platform platform, long summonerId);

        /// <summary>
        /// Gets all champions mastery by summoner ID asynchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <returns>All champions mastery entries for the specified summoner ID.</returns>
        Task<List<ChampionMastery>> GetChampionMasteriesAsync(Platform platform, long summonerId);

        /// <summary>
        /// Get a player's total champion mastery score,
        /// which is the sum of individual champion mastery levels, by summoner ID synchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <returns>Total champion mastery score for summoner ID.</returns>
        int GetTotalChampionMasteryScore(Platform platform, long summonerId);

        /// <summary>
        /// Get a player's total champion mastery score,
        /// which is the sum of individual champion mastery levels, by summoner ID asynchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <returns>Total champion mastery score for summoner ID.</returns>
        Task<int> GetTotalChampionMasteryScoreAsync(Platform platform, long summonerId);

        /// <summary>
        /// Gets specified number of top champion mastery entries,
        /// sorted by number of champion points descending, by summoner ID synchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <param name="count">Number of entries to retrieve, defaults to 3.</param>
        /// <returns>A list of the top champion mastery entries for the specified summoner ID.</returns>
        List<ChampionMastery> GetTopChampionsMasteries(Platform platform, long summonerId, int count);

        /// <summary>
        /// Gets specified number of top champion mastery entries,
        /// sorted by number of champion points descending, by summoner ID asynchronously.
        /// </summary>
        /// <param name="platform">Region where to retrieve the data.</param>
        /// <param name="summonerId">ID of the summoner for which to retrieve champion mastery.</param>
        /// <param name="count">Number of entries to retrieve, defaults to 3.</param>
        /// <returns>A list of the top champion mastery entries for the specified summoner ID.</returns>
        Task<List<ChampionMastery>> GetTopChampionsMasteriesAsync(Platform platform, long summonerId, int count);
    }
}
