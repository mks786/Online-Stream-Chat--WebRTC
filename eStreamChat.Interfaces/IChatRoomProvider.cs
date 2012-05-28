﻿/* This file is part of eStreamChat.
 * 
 * eStreamChat is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version. 
 * 
 * eStreamChat is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 * 
 * You should have received a copy of the GNU Affero General Public License
 * along with eStreamChat. If not, see <http://www.gnu.org/licenses/>.
 */
using System.Collections.Generic;

namespace eStreamChat.Interfaces
{
    public interface IChatRoomProvider
    {
        IEnumerable<Room> GetChatRooms();

        /// <summary>
        /// chatRoomId should be -2 for messenger communication
        /// </summary>
        /// <param name="chatRoomId"></param>
        /// <returns></returns>
        Room GetChatRoom(string chatRoomId);

        void BanUser(string chatRoomId, string userId, string bannedUserId);
        bool HasChatAccess(string userId, string chatRoomId, out string reason);
    }
}